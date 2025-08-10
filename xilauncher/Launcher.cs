using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;

namespace xilauncher
{
    [Serializable]
    public struct XiLoaderConfig
    {
        public string Username = "";
        public SecureString Password = new SecureString();
        public string Server = "127.0.0.1"; // localhost is default to connect to launched environment
        public bool UseHairPin = false;
        public XiLoaderConfig()
        {
        }

        public XiLoaderConfig(string userName, string unsafePassword, string server, bool hairpin)
        {
            Username = userName;
            Password = new System.Security.SecureString();
            foreach (char c in unsafePassword) Password.AppendChar(c);
            Server = server;
            UseHairPin = hairpin;
        }

        public string ToArguments()
        {
            StringBuilder sb = new StringBuilder();
            string pass = new System.Net.NetworkCredential(string.Empty, this.Password).Password;

            if (!String.IsNullOrWhiteSpace(Username)) sb.Append($"--user {this.Username} ");
            if (!String.IsNullOrWhiteSpace(pass)) sb.Append($"--pass {pass} ");
            if (!String.IsNullOrWhiteSpace(Server)) sb.Append($"--server {this.Server} ");
            if (this.UseHairPin) sb.Append("--hairpin ");
            return sb.ToString();
        }
    }

    public partial class Launcher
    {
        private const string xiMariadbArgs = "--console";

        private readonly LauncherResources _resources = new LauncherResources();
        private Process? _procDatabase;
        private Process? _procConnect;
        private Process? _procSearch;
        private Process? _procMap;
        private Process? _procWorld;
        // ToDo: add listener to process termination to track external changes to the processes
        //          (e.g. loader is shut down when exiting game, others may error critically)

        private List<Process?> _processesLoader = new List<Process?>();
        private Process? _procLoader;

        // ToDo: add 'CanLaunch' properties to allow main form to query

        public Launcher()
        {
        }

        public void Exit(bool stopDatabase, bool stopServer, bool stopGame)
        {
            if (stopDatabase)
            {
                StopDatabase();
            }
            if (stopServer)
            {
                StopServer();
            }
            if (stopGame)
            {
                StopGame();
            }
        }
        public bool LaunchGame(XiLoaderConfig config)
        {
            if (_procLoader is not null)
                return false;
            // ToDo: Ponder about a way to implement game launch but have the interface stay simple
            //          the UI should keep the single big launch button
            //          but allow for a + button to launch more game instances with different configs
            //          this will require to have loader configs as data type and map config to the processes list

            //if (_procDatabase is not null)
            //    return false;

            //Console.WriteLine("Starting local database...");
            //if (!EnsureDatabaseConfig())
            //    return false;
            //if (!EnsureDatabaseEnvironmentVariable())
            //    return false;

            _procLoader = Launch(_resources.fileLoaderExe, config.ToArguments(), _resources.dirLoader, true, true, "runas");
            if (_procLoader is not null)
            {
                Console.WriteLine("Started loader instance.");
                _procLoader.Exited += LoaderProcess_Exited;
            }
            else Console.WriteLine("Loader failed to start!");
            return _procLoader is not null;
        }

        private void LoaderProcess_Exited(object? sender, EventArgs e)
        {
            if (sender == _procLoader) 
                _procLoader = null;
        }

        private void StopGame()
        {
            if (_procLoader is not null)
            {
                Console.WriteLine($"Stopped loader instance (PID:{_procLoader.Id}).");
                _procLoader.Kill(true);
            }
            // Remark: Danger Zone: The loader is not meant to be killed as it holds into the running client
            //          though should work
            //foreach (Process? process in _processesLoader)
            //{
            //    if (process is not null)
            //    {
            //        Console.WriteLine($"Stopping game instance (PID:{process.Id}).");
            //        process.Kill(true);
            //    }
            //}
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

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = fileInfo.FullName;
            psi.Arguments = arguments;
            psi.UseShellExecute = useShell;
            //psi.CreateNoWindow = false;
            psi.WindowStyle = ProcessWindowStyle.Normal;
            psi.WorkingDirectory = workDir?.FullName ?? string.Empty;

            // set process verb (e.g.: to allow elevated execution)
            if (!String.IsNullOrWhiteSpace(verb)) psi.Verb = verb;

            Process? process = Process.Start(psi);
            // enable events on process (if created)
            if (enableEvents && process is not null) process.EnableRaisingEvents = enableEvents;
            return process;
        }

    }

}
