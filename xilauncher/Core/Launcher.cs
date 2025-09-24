using System.ComponentModel;
using System.Diagnostics;

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
            if (stopGame) await StopGame();
            if (stopServer) await StopEnvironment();
            if (stopDatabase) await StopDatabase();
        }

        /// <summary>
        /// Launches the file described by the given info (if present) and sets up and starts the process according to the given arguments
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <param name="arguments"></param>
        /// <param name="workDir"></param>
        /// <param name="enableEvents"></param>
        /// <param name="useShell"></param>
        /// <param name="verb"></param>
        /// <returns>The process started from this call, or null if something went wrong.</returns>
        public static Process? Launch(FileInfo? fileInfo, string arguments, DirectoryInfo? workDir,
            bool enableEvents = true, bool useShell = false, string verb = "")
        {
            if (fileInfo is null
                && !(fileInfo?.Exists ?? false))
                return null;

            XiLog.WriteLine($"Launching process async for '{fileInfo.FullName}' with arguments '{arguments}'");
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = fileInfo.FullName;
            psi.Arguments = arguments;
            psi.UseShellExecute = useShell;
            //psi.CreateNoWindow = false;
            psi.WindowStyle = ProcessWindowStyle.Normal;
            psi.WorkingDirectory = workDir?.FullName ?? string.Empty;

            // set process verb (e.g.: to allow elevated execution)
            if (!String.IsNullOrWhiteSpace(verb)) psi.Verb = verb;

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
            if (enableEvents && process is not null) process.EnableRaisingEvents = enableEvents;
            return process;
        }

        /// <summary>
        /// Launches the file described by the given info (if present) and sets up and starts the process according to the given arguments
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <param name="arguments"></param>
        /// <param name="workDir"></param>
        /// <param name="enableEvents"></param>
        /// <param name="useShell"></param>
        /// <param name="verb"></param>
        /// <param name="redirectStreams"></param>
        /// <returns>The process started from this call, or null if something went wrong.</returns>
        public static async Task<Process?> LaunchAsync(FileInfo? fileInfo, string arguments, DirectoryInfo? workDir,
    bool enableEvents = true, bool useShell = true, string verb = "", bool redirectStreams = false)
        {
            if (fileInfo is null
                && !(fileInfo?.Exists ?? false))
                return null;

            XiLog.WriteLine($"Launching process for '{fileInfo.FullName}' with arguments '{arguments}'");
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = $"{fileInfo.FullNameWithAltSeparator()}";
            psi.Arguments = arguments;
            psi.UseShellExecute = useShell;
            //psi.CreateNoWindow = false;
            psi.WindowStyle = ProcessWindowStyle.Normal;
            psi.WorkingDirectory = workDir?.FullNameWithAltSeparator() ?? string.Empty;

            psi.RedirectStandardOutput = redirectStreams;
            psi.RedirectStandardInput = redirectStreams;
            psi.RedirectStandardError = redirectStreams;
            // set process verb (e.g.: to allow elevated execution)
            if (!String.IsNullOrWhiteSpace(verb)) psi.Verb = verb;

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
            if (enableEvents && process is not null) process.EnableRaisingEvents = enableEvents;
            return process;
        }

    }

}
