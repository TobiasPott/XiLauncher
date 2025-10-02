using System.ComponentModel;
using System.Diagnostics;
using xilauncher.Configuration;

namespace xilauncher
{

    /// <summary>
    /// Enumeration of states the different modules' processes can be in
    /// </summary>
    public enum LauncherState
    {
        Stopped,
        Starting,
        Running,
        Stopping,
        Errored
    }

    /// <summary>
    /// delegate used for signaling state changes of the launcher's internal modules
    /// </summary>
    /// <param name="modules">a bitmask of modules that have their state changed</param>
    /// <param name="state">the state the given modules have changed to</param>
    public delegate void LauncherEvent(Launcher.Modules modules, LauncherState state);

    /// <summary>
    /// Class that provides access to subprocesses & resources and internally tracks the running instances
    /// </summary>
    public partial class Launcher
    {

        /// <summary>
        /// Enumerations of modules the launcher internally works with
        /// </summary>
        [Flags()]
        public enum Modules
        {
            Default = 0,
            Environment = 1,
            XiConnect = 2,
            XiSearch = 4,
            XiWorld = 8,
            XiMap = 16,
            Database = 32,
            Loader = 64,
        }

        /// <summary>
        /// event called when a subprocess of the launcher changes it's state
        /// </summary>
        public event LauncherEvent? ProcessChanged = null;


        private readonly LauncherResources _resources;
        private Process? _procDatabase;
        private Process? _procConnect;
        private Process? _procSearch;
        private Process? _procMap;
        private Process? _procWorld;
        private Process? _procLoader;


        /// <summary>
        /// The current resources used by the launcher.
        /// </summary>
        public LauncherResources Resources { get { return _resources; } }

        private void OnProcessChanged(Modules modules, LauncherState state)
        {
            ProcessChanged?.Invoke(modules, state);
        }

        public Launcher(LauncherResources resources)
        {
            _resources = resources;
        }

        /// <summary>
        /// Exit the launcher and all running subprocesses in order
        /// </summary>
        /// <param name="stopDatabase">whether or not to stop the database process</param>
        /// <param name="stopServer">whether or not to stop the environment process</param>
        /// <param name="stopGame">whether or not to stop the game process</param>
        /// <returns>A task that represents a exiting function and it's progress</returns>
        public async Task Exit(bool stopDatabase, bool stopServer, bool stopGame)
        {
            if (stopGame) await StopModule(Modules.Loader);
            if (stopServer) await StopModule(Modules.Environment);
            if (stopDatabase) await StopModule(Modules.Database);
        }

        public async Task<bool> StartModule(Modules module, IWin32Window? owner = null)
        {
            if (this.IsProcessActive(module))
            {
                DialogResult result = DialogResult.Yes;
                if (owner != null)
                {
                    string message = String.Format($"{module} {UITexts.MsgBox_Msg_IsRunning}");
                    result = ReaLTaiizor.Controls.PoisonMessageBox.Show(owner, message, UITexts.MsgBox_Title_StopProcess, MessageBoxButtons.YesNo);
                }
                if (result == DialogResult.Yes)
                    await this.StopModule(module);
            }
            else if (await this.LaunchModule(module))
                return true;

            return false;
        }
        private async Task StopModule(Modules module)
        {
            switch (module)
            {
                case Modules.Default: break;
                case Modules.Environment:
                    await this.StopEnvironment(); break;
                case Modules.XiConnect:
                    await StopXiConnectServer(); break;
                case Modules.XiSearch:
                    await StopXiSearchServer(); break;
                case Modules.XiWorld:
                    await StopXiWorldServer(); break;
                case Modules.XiMap:
                    await StopXiMapServer(); break;
                case Modules.Database:
                    await StopDatabase(); break;
                case Modules.Loader:
                    await this.StopGame(); break;
            }
        }

        private async Task<bool> LaunchModule(Modules module)
        {
            switch (module)
            {
                case Modules.Default:
                    return false;
                case Modules.Environment:
                    return await this.LaunchEnvironment(CancellationToken.None);
                case Modules.XiConnect:
                    return await this.LaunchXiConnectServer(CancellationToken.None);
                case Modules.XiSearch:
                    return await this.LaunchXiSearchServer(CancellationToken.None);
                case Modules.XiWorld:
                    return await this.LaunchXiWorldServer(CancellationToken.None);
                case Modules.XiMap:
                    return await this.LaunchXiMapServer(CancellationToken.None);
                case Modules.Database:
                    return await this.LaunchDatabase();
                case Modules.Loader:
                    if (LauncherSettings.Default.StoredAccount != null)
                        return await this.LaunchGame(LauncherSettings.Default.StoredAccount);
                    return false;
            }
            return false;
        }

        //private async Task<bool> LaunchGame(XiLoaderUserConfig config)
        //{
        //    if (_procLoader is not null)
        //        return false;

        //    this.OnProcessChanged(LauncherModules.Loader, LauncherState.Starting);
        //    XiLog.WriteLine("Starting game instance...");
        //    _procLoader = await LaunchAsync(_resources.fileLoaderExe, config.ToArguments(), _resources.dirLoader,
        //        true, true, "runas");
        //    if (_procLoader is not null)
        //    {
        //        XiLog.WriteLine("Started loader instance.");
        //        _procLoader.Exited += LoaderProcess_Exited;
        //    }
        //    else XiLog.WriteLine("Loader failed to start!");

        //    this.OnProcessChanged(LauncherModules.Loader, _procLoader is not null ? LauncherState.Running : LauncherState.Errored);
        //    return _procLoader is not null;
        //}


        private async Task<Process?> StartProcess(Process? proc, Modules module,
            XiLogProcessRedirector? redirector = null, FileInfo? file = null, DirectoryInfo? workingDir = null, ProcessParams launchParams = default)
        {
            if (proc is not null)
                return null; // return to indicate no new process was started

            this.OnProcessChanged(module, LauncherState.Starting);
            XiLog.WriteLine($"Starting {module} instance...");

            _procLoader = await LaunchAsync(file, workingDir, launchParams);
            if (_procLoader is not null)
            {
                XiLog.WriteLine("Started loader instance.");
                _procLoader.Exited += LoaderProcess_Exited;
            }
            else XiLog.WriteLine("Loader failed to start!");

            this.OnProcessChanged(Modules.Loader, _procLoader is not null ? LauncherState.Running : LauncherState.Errored);

            return proc;
        }

        private async Task<bool> StopProcess(Process? proc, Modules module, XiLogProcessRedirector? redirector = null)
        {
            // check if process is null reference
            if (proc is null)
                return false;

            this.OnProcessChanged(module, LauncherState.Stopping);
            await Task.Delay(16);
            proc.Kill(true);
            // detach log redirector
            redirector?.Detach();
            // reset reference and dispatch event
            XiLog.WriteLine($"Stopped {module}.");
            proc = null;
            await Task.Delay(16);
            this.OnProcessChanged(module, LauncherState.Stopped);
            return true;
        }


        /// <summary>
        /// Launches the file described by the given info (if present) and sets up and starts the process according to the given arguments
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <param name="arguments"></param>
        /// <param name="workDir"></param>
        /// <param name="launchParams"></param>
        /// <param name="enableEvents"></param>
        /// <param name="useShell"></param>
        /// <param name="verb"></param>
        /// <returns>The process started from this call, or null if something went wrong.</returns>
        internal static Process? Launch(FileInfo? fileInfo, DirectoryInfo? workDir, ProcessParams launchParams
            /*, bool enableEvents = true, bool useShell = false, string verb = ""*/)
        {
            if (fileInfo is null
                && !(fileInfo?.Exists ?? false))
                return null;

            XiLog.WriteLine($"Launching process async for '{fileInfo.FullName}' with arguments '{launchParams.Args}'");
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = fileInfo.FullName;
            psi.Arguments = launchParams.Args;
            psi.UseShellExecute = launchParams.UseShell;
            //psi.CreateNoWindow = false;
            psi.WindowStyle = ProcessWindowStyle.Normal;
            psi.WorkingDirectory = workDir?.FullName ?? string.Empty;

            // set process verb (e.g.: to allow elevated execution)
            if (!String.IsNullOrWhiteSpace(launchParams.Verb)) psi.Verb = launchParams.Verb;

            Process? process = null;
            try
            {
                process = Process.Start(psi);
            }
            catch (Win32Exception w32ex)
            {
                XiLog.WriteLine($"Failed to launch process: {fileInfo.FullName}");
                XiLog.WriteLine(w32ex.Message);
            }
            // enable events on process (if created)
            if (launchParams.EnableEvents && process is not null) process.EnableRaisingEvents = launchParams.EnableEvents;
            return process;
        }

        /// <summary>
        /// Launches the file described by the given info (if present) and sets up and starts the process according to the given arguments
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <param name="arguments"></param>
        /// <param name="workDir"></param>
        /// <param name="launchParams"></param>
        /// <param name="enableEvents"></param>
        /// <param name="useShell"></param>
        /// <param name="verb"></param>
        /// <param name="redirectStreams"></param>
        /// <returns>The process started from this call, or null if something went wrong.</returns>
        internal static async Task<Process?> LaunchAsync(FileInfo? fileInfo, DirectoryInfo? workDir, ProcessParams launchParams
            /*, bool enableEvents = true, bool useShell = true, string verb = "", bool redirectStreams = false*/)
        {
            if (fileInfo is null
                && !(fileInfo?.Exists ?? false))
                return null;

            XiLog.WriteLine($"Launching process for '{fileInfo.FullName}' with arguments '{launchParams.Args}'");
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = $"{fileInfo.FullNameWithAltSeparator()}";
            psi.Arguments = launchParams.Args;
            psi.UseShellExecute = launchParams.UseShell;
            //psi.CreateNoWindow = false;
            psi.WindowStyle = ProcessWindowStyle.Normal;
            psi.WorkingDirectory = workDir?.FullNameWithAltSeparator() ?? string.Empty;

            psi.RedirectStandardOutput = launchParams.RedirectStreams;
            psi.RedirectStandardInput = launchParams.RedirectStreams;
            psi.RedirectStandardError = launchParams.RedirectStreams;
            // set process verb (e.g.: to allow elevated execution)
            if (!String.IsNullOrWhiteSpace(launchParams.Verb)) psi.Verb = launchParams.Verb;

            Process? process = null;
            await Task.Run(() =>
            {
                try
                {
                    process = Process.Start(psi);
                }
                catch (Win32Exception w32ex)
                {
                    XiLog.WriteLine($"Failed to launch process: {fileInfo.FullName}");
                    XiLog.WriteLine(w32ex.Message);
                }
                return Task.CompletedTask;
            });
            //Process? process = Process.Start(psi);
            // enable events on process (if created)
            if (launchParams.EnableEvents && process is not null) process.EnableRaisingEvents = launchParams.EnableEvents;
            return process;
        }




    }

}
