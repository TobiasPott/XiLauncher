using System.Diagnostics;
using System.Security;

namespace xilauncher
{

    internal struct LoaderOptions
    {
        public string Server = "127.0.0.1"; // localhost is default to connect to launched environment
        public bool UseHairPin = false;
        public string Username = "";
        public SecureString Password = new SecureString();
        public LoaderOptions()
        {
        }
    }

    internal partial class Launcher
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
        public bool LaunchGame()
        {
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

            //_procDatabase = Launch(_resources.fileMysqldExe, xiMariadbArgs, _resources.dirMariadb);
            //if (_procDatabase is not null) Console.WriteLine("Started local database.");
            //else Console.WriteLine("Database failed to start!");

            //return _procDatabase is not null;
            return false;
        }
        private void StopGame()
        {
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

        // ToDo:: add redirect of std out and std err
        public static Process? Launch(FileInfo? fileInfo, string arguments, DirectoryInfo? workDir)
        {
            if (fileInfo is null
                && !(fileInfo?.Exists ?? false))
                return null;

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = fileInfo.FullName;
            psi.Arguments = arguments;
            psi.UseShellExecute = false;
            //psi.CreateNoWindow = false;
            psi.WindowStyle = ProcessWindowStyle.Normal;
            psi.WorkingDirectory = workDir?.FullName ?? string.Empty;

            return Process.Start(psi);
        }

    }

}
