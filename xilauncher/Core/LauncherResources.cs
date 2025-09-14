using System.Diagnostics;

namespace xilauncher
{
    public class LauncherResources
    {
        #region Events
        /// <summary>
        /// event fired when the resources are refreshed on creation or by user call
        /// </summary>
        public event Action? Refreshed = null;

        #endregion

        #region Constants
        private const string data = "data";
        private const string bin = "bin";
        private const string lib = "lib";
        private const string plugin = "plugin";


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


        private const string buildDebugDir = "bin/debug"; 
        private const string buildDebugDirAlt = @"bin\debug"; 
        private const string buildReleaseDir = "bin/release";
        private const string buildReleaseDirAlt = @"bin\release";

        #endregion


        #region Fields
        private string xiBasePath = @"unresolved";

        #endregion


        #region Properties
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


        public bool IsDatabaseLaunchSupported => fileMysqldExe != null && fileMysqldExe.Exists;
        public bool IsEnvironmentLaunchSupported => fileLoaderExe != null && fileLoaderExe.Exists;
        public bool IsGameLaunchSupported => fileConnectExe != null && fileConnectExe.Exists
                                            && fileSearchExe != null && fileSearchExe.Exists
                                            && fileWorldExe != null && fileWorldExe.Exists
                                            && fileMapExe != null && fileMapExe.Exists;

        #endregion


        public LauncherResources()
        {
            dirBase = new DirectoryInfo("LauncherResourcesNotInitialised");
        }

        /// <summary>
        /// Forces the resources to refresh and update availability of the environment, database and game process resources.
        /// </summary>
        public void RefreshResources()
        {
            string appPath = Application.StartupPath;
            dirBase = appPath.ToDirectoryInfo().Parent ?? appPath.ToDirectoryInfo();

            string dirBasePath = dirBase.FullName.ToLowerInvariant();
            // check for debug/release builds from visual studio 
            if (dirBasePath.Contains(buildDebugDir) || dirBasePath.Contains(buildDebugDirAlt)
                || dirBasePath.Contains(buildReleaseDir) || dirBasePath.Contains(buildReleaseDirAlt))
                // pick the specific parent folder as base (assuming xiloader and other process share a common root above the solution folder)
                dirBase = dirBase.Parent?.Parent?.Parent?.Parent ?? appPath.ToDirectoryInfo();

            XiLog.WriteLine($"Launcher resources located at: {dirBase.FullName}");
            if (!dirBase.FullName.Equals(appPath))
                XiLog.WriteLine($"Launcher origin is: {appPath}");

            // set base path to the directory determined from refresh
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

            // iterate over all directories and files and print some info to the log
            bool allValid = true;
            foreach (var fileInfo in filesAndDirectories)
            {
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
        /// <summary>
        /// Convert the string value to a FileInfo instance
        /// </summary>
        /// <param name="value">the value to intepret as the file's path</param>
        /// <returns>A FileInfo object with the given string value as path, this can be invalid.</returns>
        public static FileInfo ToFileInfo(this string value)
        { return new FileInfo(value); }
        /// <summary>
        /// Convert the string value to a DirectoryInfo instance
        /// </summary>
        /// <param name="value">the value to intepret as the directories' path</param>
        /// <returns>A DirectoryInfo object with the given string value as path, this can be invalid.</returns>
        public static DirectoryInfo ToDirectoryInfo(this string value)
        { return new DirectoryInfo(value); }

    }
}
