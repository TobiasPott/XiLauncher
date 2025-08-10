using System.Diagnostics;

namespace xilauncher
{
    internal class LauncherResources
    {
        private const string data = "data";
        private const string bin = "bin";
        private const string lib = "lib";
        private const string plugins = "plugins";


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


        internal DirectoryInfo dirBase {  get; private set; }
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
        internal DirectoryInfo? dirMysqlPlugins { get; private set; }


        public LauncherResources()
        {
            this.RefreshResources();
            // ToDo: sample to get cli arguments anywhere in code
            // --rootDir [...]
            foreach (String arg in Environment.GetCommandLineArgs())
            {
                Console.Write("Argument: " + arg);
            }
            dirBase = new DirectoryInfo("LauncherResourcesNotInitialised");
        }

        public void RefreshResources()
        {
            FileInfo fiAppExec = new FileInfo(Application.ExecutablePath);
            xiBasePath = fiAppExec.Directory?.Parent?.FullName ?? @".\";
#if DEBUG
            xiBasePath = @"C:\Development\Standalone\LandSandBoat";
#endif
            // ToDo: Figure out a way to override xiBasePath for release builds
            //      should be good point to add CLI argument support
            dirBase = xiBasePath.ToDirectoryInfo();
            Debug.WriteLine($"Launcher was started at: {xiBasePath}");
            this.ValidateFilesAndDirectories();
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
            string mysqlPluginsDir = Path.Combine(mariadbDir, lib, plugins);

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
            dirMysqlPlugins = mysqlPluginsDir.ToDirectoryInfo();

            List<FileSystemInfo?> filesAndDirectories = new List<FileSystemInfo?>() {
                dirBase,
                dirLauncher,
                dirLoader, fileLoaderExe,
                dirServer, fileConnectExe, fileSearchExe, fileWorldExe, fileMapExe,
                dirMariadb, fileMysqldExe, fileMyIni, dirMysqlData, dirMysqlPlugins
            };
            bool allValid = true;
            //foreach (FileSystemInfo? fileInfo in filesAndDirectories)
            for (int i = 0; i < filesAndDirectories.Count; i++)
            {
                FileSystemInfo? fileInfo = filesAndDirectories[i];
                if (fileInfo is not null)
                {
                    Debug.WriteLineIf(!fileInfo.Exists, $"{fileInfo.GetType().Name} at path: '{fileInfo.FullName}' does not exist.");

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
