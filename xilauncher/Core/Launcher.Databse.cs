using System.Diagnostics;

namespace xilauncher
{
    public partial class Launcher
    {
        private const string xiMariadbArgs = "--console";

        /// <summary>
        /// returns whether or not the database process started by the launcher was started already
        /// </summary>
        public bool IsDatabaseProcessActive => _procDatabase is not null;

        private bool EnsureDatabaseConfig()
        {
            if (_resources.fileMyIni is not null && _resources.fileMyIni.Exists
                && _resources.dirMysqlData is not null
                && _resources.dirMysqlPlugin is not null)
            {
                StreamReader srMyIni = new StreamReader(_resources.fileMyIni.OpenRead());
                string[] myIniLines = srMyIni.ReadToEnd().Split(Environment.NewLine);
                srMyIni.Close();
                for (int i = 0; i < myIniLines.Length; i++)
                {
                    string line = myIniLines[i];
                    if (line.StartsWith("datadir="))
                        myIniLines[i] = $"datadir={_resources.dirMysqlData.FullNameWithAltSeparator()}";
                    else if (line.StartsWith("plugin-dir="))
                        myIniLines[i] = $"plugin-dir={_resources.dirMysqlPlugin.FullNameWithAltSeparator()}";
                }

                StreamWriter swMyIni = new StreamWriter(_resources.fileMyIni.OpenWrite());
                swMyIni.Write(String.Join(Environment.NewLine, myIniLines));
                swMyIni.Flush();
                swMyIni.Close();
                return true;
            }
            else
                return false;
        }
        private bool EnsureDatabaseEnvironmentVariable()
        {
            if (_resources.dirMariadb is null
                || !_resources.dirMariadb.Exists)
                return false;
            // setting MYSQL_HOME for current launcher process (should be able to pass them to everything launched from here)
            System.Environment.SetEnvironmentVariable("MYSQL_HOME", _resources.dirMariadb.FullNameWithAltSeparator(), EnvironmentVariableTarget.User);
            return true;
        }

        /// <summary>
        /// Launches a new instance of the database process (if none was started yet)
        /// </summary>
        /// <returns>true if a process was started, false otherwise</returns>
        public async Task<bool> LaunchDatabase()
        {
            if (_procDatabase is not null)
                return false;

            this.OnProcessChanged(LauncherModules.Database, LauncherState.Starting);
            XiLog.WriteLine("Starting local database...");
            if (!EnsureDatabaseConfig()
                || !EnsureDatabaseEnvironmentVariable())
            {
                this.OnProcessChanged(LauncherModules.Database, LauncherState.Errored);
                return false;
            }


            _procDatabase = await LaunchAsync(_resources.fileMysqldExe, xiMariadbArgs, _resources.dirMariadb,
                true, false, "", true);

            if (_procDatabase is not null) XiLog.WriteLine("Started local database.");
            else XiLog.WriteLine("Database failed to start!");
            XiLogProcessRedirector.DatabaseRedirector.Attach(_procDatabase);

            this.OnProcessChanged(LauncherModules.Database, _procDatabase is not null ? LauncherState.Running : LauncherState.Errored);
            return _procDatabase is not null;
        }

        /// <summary>
        /// Stops the active instance of the database process
        /// </summary>
        /// <returns>The completed task of killing & resetting the database process instance</returns>
        public async Task StopDatabase()
        {
            if (_procDatabase is not null)
            {
                this.OnProcessChanged(LauncherModules.Database, LauncherState.Stopping);
                await Task.Delay(16);
                _procDatabase.Kill(true);
                // detach log redirector
                XiLogProcessRedirector.DatabaseRedirector.Detach();
                // reset reference and dispatch event
                XiLog.WriteLine("Stopped local database.");
                _procDatabase = null;
                await Task.Delay(16);
                this.OnProcessChanged(LauncherModules.Database, LauncherState.Stopped);
            }
        }
    }

}
