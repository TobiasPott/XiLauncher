using System.Diagnostics;

namespace xilauncher
{
    public class LauncherResources
    {
        private const string data = "data";
        private const string bin = "bin";
        private const string lib = "lib";
        private const string plugin = "plugin";


        private string xiBasePath = @"unresolved";
        private const string xiLauncherDir = "xilauncher";

        private const string xiLoaderDir = "xiloader";
        private const string xiLoaderExe = "xiloader.exe";

        private const string xiMariaDBDir = "ximariadb";
        private const string xiMariaDBMySqlExe = @"mysqld.exe";
        private const string xiMariaDBMyIni = @"my.ini";

        private const string xiServerDir = "xiserver";
        private const string xiConnectExe = "xi_connect.exe";
        private const string xiSearchExe = "xi_search.exe";
        private const string xiWorldExe = "xi_world.exe";
        private const string xiMapExe = "xi_map.exe";


        public event Action? Refreshed = null;


        internal DirectoryInfo dirBase { get; private set; }
        internal DirectoryInfo? dirLauncher { get; private set; }

        internal DirectoryInfo? dirLoader { get; private set; }
        internal FileInfo? fileLoaderExe { get; private set; }

        internal DirectoryInfo? dirServer { get; private set; }
        internal FileInfo? fileConnectExe { get; private set; }
        internal FileInfo? fileSearchExe { get; private set; }
        internal FileInfo? fileWorldExe { get; private set; }
        internal FileInfo? fileMapExe { get; private set; }

        internal DirectoryInfo? dirMariadb { get; private set; }
        internal FileInfo? fileMysqldExe { get; private set; }
        internal FileInfo? fileMyIni { get; private set; }
        internal DirectoryInfo? dirMysqlData { get; private set; }
        internal DirectoryInfo? dirMysqlPlugin { get; private set; }


        public LauncherResources()
        {
            dirBase = new DirectoryInfo("LauncherResourcesNotInitialised");
            // ToDo: sample to get cli arguments anywhere in code
            // --rootDir [...]
            //foreach (String arg in Environment.GetCommandLineArgs())
            //{
            //    Console.Write("Argument: " + arg);
            //}
        }

        public void RefreshResources()
        {
            string appPath = Application.StartupPath;
            dirBase = appPath.ToDirectoryInfo().Parent ?? appPath.ToDirectoryInfo();

            string dirBasePath = dirBase.FullName.ToLowerInvariant();
            if (dirBasePath.Contains("bin/debug") || dirBasePath.Contains(@"bin\debug")
                || dirBasePath.Contains("bin/release") || dirBasePath.Contains(@"bin\release"))
                dirBase = dirBase.Parent?.Parent?.Parent?.Parent ?? appPath.ToDirectoryInfo();
            
            XiLog.WriteLine($"Launcher resources located at: {dirBase.FullName}");
            if (!dirBase.FullName.Equals(appPath))
                XiLog.WriteLine($"Launcher origin is: {appPath}");

            // set base path to the directory determinded from refresh
            xiBasePath = dirBase.FullName;

            this.ValidateFilesAndDirectories();
            // dispatch refresh event
            this.Refreshed?.Invoke();
        }

        private bool ValidateFilesAndDirectories()
        {
            string loaderDir = Path.Combine(xiBasePath, xiLoaderDir);
            string loaderExe = Path.Combine(loaderDir, xiLoaderExe);

            string serverDir = Path.Combine(xiBasePath, xiServerDir);
            string connectExe = Path.Combine(serverDir, xiConnectExe);
            string searchExe = Path.Combine(serverDir, xiSearchExe);
            string worldExe = Path.Combine(serverDir, xiWorldExe);
            string mapExe = Path.Combine(serverDir, xiMapExe);

            string mariadbDir = Path.Combine(xiBasePath, xiMariaDBDir);
            string mysqldExe = Path.Combine(mariadbDir, bin, xiMariaDBMySqlExe);
            string myIni = Path.Combine(mariadbDir, data, xiMariaDBMyIni);
            string mysqlBinDir = Path.Combine(mariadbDir, data);
            string mysqlPluginsDir = Path.Combine(mariadbDir, lib, plugin);

            dirLoader = loaderDir.ToDirectoryInfo();
            fileLoaderExe = loaderExe.ToFileInfo();

            dirServer = serverDir.ToDirectoryInfo();
            fileConnectExe = connectExe.ToFileInfo();
            fileSearchExe = searchExe.ToFileInfo();
            fileWorldExe = worldExe.ToFileInfo();
            fileMapExe = mapExe.ToFileInfo();

            dirMariadb = mariadbDir.ToDirectoryInfo();
            fileMysqldExe = mysqldExe.ToFileInfo();
            fileMyIni = myIni.ToFileInfo();
            dirMysqlData = mysqlBinDir.ToDirectoryInfo();
            dirMysqlPlugin = mysqlPluginsDir.ToDirectoryInfo();

            List<FileSystemInfo?> filesAndDirectories = new List<FileSystemInfo?>() {
                dirBase,
                dirLauncher,
                dirLoader, fileLoaderExe,
                dirServer, fileConnectExe, fileSearchExe, fileWorldExe, fileMapExe,
                dirMariadb, fileMysqldExe, fileMyIni, dirMysqlData, dirMysqlPlugin
            };
            bool allValid = true;
            //foreach (FileSystemInfo? fileInfo in filesAndDirectories)
            for (int i = 0; i < filesAndDirectories.Count; i++)
            {
                FileSystemInfo? fileInfo = filesAndDirectories[i];
                if (fileInfo is not null)
                {
                    XiLog.WriteLine($"{fileInfo.Exists} <- {fileInfo.GetType().Name} at path: '{fileInfo.FullName}'.");

                    if (!fileInfo.Exists)
                    {
                        allValid = false;
                    }
                }
            }
            return allValid;
        }

    }

    public static class StringExtensions
    {
        public static FileInfo ToFileInfo(this string value)
        { return new FileInfo(value); }
        public static DirectoryInfo ToDirectoryInfo(this string value)
        { return new DirectoryInfo(value); }

    }
}
