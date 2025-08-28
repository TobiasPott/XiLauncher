using System.ComponentModel;
using System.Diagnostics;

namespace xilauncher
{

    [Flags()]
    public enum LauncherModules
    {
        Default = 0,
        Environment = 1,
        ConnectServer = 2,
        SearchServer = 4,
        WorldServer = 8,
        MapServer = 16,
        Database = 32,
        Loader = 64,
    }
    public enum LauncherState
    {
        Stopped,
        Starting,
        Running,
        Stopping,
        Errored
    }

    public delegate void LauncherEvent(LauncherModules modules, LauncherState state);

    public partial class Launcher
    {
        private const string xiMariadbArgs = "--console";


        public event LauncherEvent? ProcessChanged = null;


        private readonly LauncherResources _resources;
        private Process? _procDatabase;
        private CancellationTokenSource _cancellationSourceDatabase = new CancellationTokenSource();

        private Process? _procConnect;
        private Process? _procSearch;
        private Process? _procMap;
        private Process? _procWorld;
        private CancellationTokenSource _cancellationSourceEnvironment = new CancellationTokenSource();

        private List<Process?> _processesLoader = new List<Process?>();
        private Process? _procLoader;
        private CancellationTokenSource _cancellationSourceLoader = new CancellationTokenSource();


        public LauncherResources Resources { get { return _resources; } }


        // ToDo: add 'CanLaunch' properties to allow main form to query
        private void OnProcessChanged(LauncherModules modules, LauncherState state)
        {
            ProcessChanged?.Invoke(modules, state);
        }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public Launcher(LauncherResources resources)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        {
            _resources = resources;
        }

        public async Task Exit(bool stopDatabase, bool stopServer, bool stopGame)
        {
            if (stopDatabase)
            {
                await StopDatabase();
            }
            if (stopServer)
            {
                await StopEnvironment();
            }
            if (stopGame)
            {
                StopGame();
            }
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
        public static async Task<Process?> LaunchAsync(FileInfo? fileInfo, string arguments, DirectoryInfo? workDir,
    bool enableEvents = true, bool useShell = true, string verb = "", bool redirectStreams = false)
        {
            if (fileInfo is null
                && !(fileInfo?.Exists ?? false))
                return null;

            XiLog.WriteLine($"Launching process for '{fileInfo.FullName}' with arguments '{arguments}'");
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = fileInfo.FullName;
            psi.Arguments = arguments;
            psi.UseShellExecute = useShell;
            //psi.CreateNoWindow = false;
            psi.WindowStyle = ProcessWindowStyle.Normal;
            psi.WorkingDirectory = workDir?.FullName ?? string.Empty;
            
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
