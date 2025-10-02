namespace xilauncher
{
    public partial class Launcher
    {
        private const string xiMariadbArgs = "--console";

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
            // ToDo: check if env scope = 'Process' works as desired as the 'User' scope can cause timeouts on the Win32 send message which can block the caller
            Environment.SetEnvironmentVariable("MYSQL_HOME", _resources.dirMariadb.FullNameWithAltSeparator(), EnvironmentVariableTarget.User);
            return true;
        }

        /// <summary>
        /// Launches a new instance of the database process (if none was started yet)
        /// </summary>
        /// <returns>true if a process was started, false otherwise</returns>
        private async Task<bool> LaunchDatabase()
        {
            if (!EnsureDatabaseConfig())
            {
                this.OnProcessChanged(LauncherModules.Database, LauncherState.Errored);
                return false;
            }
            if (!EnsureDatabaseEnvironmentVariable())
            {
                this.OnProcessChanged(LauncherModules.Database, LauncherState.Errored);
                return false;
            }

            if (_procDatabase is not null)
                return false;

            this.OnProcessChanged(LauncherModules.Database, LauncherState.Starting);
            XiLog.WriteLine("Starting local database...");
            _procDatabase = await LaunchAsync(_resources.fileMysqldExe, _resources.dirMariadb,
                ProcessLaunchParams.DefaultWithArgs(xiMariadbArgs, redirectStreams: true));
            //true, false, "", true);

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
        private async Task StopDatabase()
        {
            if (await this.StopProcess(_procDatabase, LauncherModules.Database, XiLogProcessRedirector.DatabaseRedirector))
                _procDatabase = null;
        }


    }

}
