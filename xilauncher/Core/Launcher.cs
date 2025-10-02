using System.ComponentModel;
using System.Diagnostics;
using xilauncher.Configuration;

namespace xilauncher
{

    /// <summary>
    /// Enumerations of modules the launcher internally works with
    /// </summary>
    [Flags()]
    public enum LauncherModules
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
    public delegate void LauncherEvent(LauncherModules modules, LauncherState state);

    /// <summary>
    /// Class that provides access to subprocesses & resources and internally tracks the running instances
    /// </summary>
    public partial class Launcher
    {
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

        private void OnProcessChanged(LauncherModules modules, LauncherState state)
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
            if (stopGame) await StopModule(LauncherModules.Loader);
            if (stopServer) await StopModule(LauncherModules.Environment);
            if (stopDatabase) await StopModule(LauncherModules.Database);
        }

        public async Task<bool> StartModule(LauncherModules module, IWin32Window? owner = null)
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
        private async Task StopModule(LauncherModules module)
        {
            switch (module)
            {
                case LauncherModules.Default: break;
                case LauncherModules.Environment:
                    await this.StopEnvironment(); break;
                case LauncherModules.XiConnect:
                    await StopXiConnectServer(); break;
                case LauncherModules.XiSearch:
                    await StopXiSearchServer(); break;
                case LauncherModules.XiWorld:
                    await StopXiWorldServer(); break;
                case LauncherModules.XiMap:
                    await StopXiMapServer(); break;
                case LauncherModules.Database:
                    await StopDatabase(); break;
                case LauncherModules.Loader:
                    await this.StopGame(); break;
            }
        }

        private async Task<bool> LaunchModule(LauncherModules module)
        {
            switch (module)
            {
                case LauncherModules.Default:
                    return false;
                case LauncherModules.Environment:
                    return await this.LaunchEnvironment(CancellationToken.None);
                case LauncherModules.XiConnect:
                    return await this.LaunchXiConnectServer(CancellationToken.None);
                case LauncherModules.XiSearch:
                    return await this.LaunchXiSearchServer(CancellationToken.None);
                case LauncherModules.XiWorld:
                    return await this.LaunchXiWorldServer(CancellationToken.None);
                case LauncherModules.XiMap:
                    return await this.LaunchXiMapServer(CancellationToken.None);
                case LauncherModules.Database:
                    return await this.LaunchDatabase();
                case LauncherModules.Loader:
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


        private async Task<Process?> StartProcess(Process? proc, LauncherModules module,
            XiLogProcessRedirector? redirector = null, FileInfo? file = null, DirectoryInfo? workingDir = null, ProcessLaunchParams launchParams = default)
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

            this.OnProcessChanged(LauncherModules.Loader, _procLoader is not null ? LauncherState.Running : LauncherState.Errored);

            return proc;
        }

        private async Task<bool> StopProcess(Process? proc, LauncherModules module, XiLogProcessRedirector? redirector = null)
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
        internal static Process? Launch(FileInfo? fileInfo, DirectoryInfo? workDir, ProcessLaunchParams launchParams
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
        internal static async Task<Process?> LaunchAsync(FileInfo? fileInfo, DirectoryInfo? workDir, ProcessLaunchParams launchParams
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

    public struct ProcessLaunchParams
    {
        public static readonly ProcessLaunchParams Default = new ProcessLaunchParams();
        public static readonly ProcessLaunchParams DefaultUseShell = new ProcessLaunchParams(useShell: true);


        public string Args;
        public bool EnableEvents;
        public bool UseShell;
        public string Verb;
        public bool RedirectStreams;

        public ProcessLaunchParams()
        {
            this.Args = string.Empty;
            this.EnableEvents = true;
            this.UseShell = false;
            this.Verb = string.Empty;
            this.RedirectStreams = true;
        }
        public ProcessLaunchParams(string args = "", bool enableEvents = true, bool useShell = false, string verb = "", bool redirectStreams = true)
        {
            this.Args = args;
            this.EnableEvents = enableEvents;
            this.UseShell = useShell;
            this.Verb = verb;
            this.RedirectStreams = redirectStreams;
        }
        public static  ProcessLaunchParams DefaultWithArgs(string args = "", bool redirectStreams = true)
        {
            ProcessLaunchParams result = Default;
            result.Args = args;
            result.RedirectStreams = redirectStreams;
            return result;
        }
        public static ProcessLaunchParams Shell(string args = "", bool enableEvents = true, string verb = "", bool redirectStreams = true)
        {
            ProcessLaunchParams result = DefaultUseShell;
            result.Args = args;
            result.EnableEvents = enableEvents;
            result.Verb = verb;
            result.RedirectStreams = redirectStreams;
            return result;
        }

        // "", true, false, "", true
    }

}
