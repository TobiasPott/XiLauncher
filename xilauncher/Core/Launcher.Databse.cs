using System.Diagnostics;

namespace xilauncher
{
    public partial class Launcher
    {
        public bool IsDatabaseProcessActive => _procDatabase is not null;

        private XiLogProcessRedirector _logDatabaseRedirector = new XiLogProcessRedirector(XiLog.XiLogCategory.Database);

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
                        myIniLines[i] = $"datadir={_resources.dirMysqlData.FullName}";
                    else if (line.StartsWith("plugin-dir="))
                        myIniLines[i] = $"plugin-dir={_resources.dirMysqlPlugin.FullName}";
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
            System.Environment.SetEnvironmentVariable("MYSQL_HOME", _resources.dirMariadb.FullName, EnvironmentVariableTarget.User);
            return true;
        }


        private Task? logTask = null;
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

            _logDatabaseRedirector.Attach(_procDatabase);
            //// enable output and error retrieval
            //if (_procDatabase is not null)
            //{
            //    _procDatabase.OutputDataReceived += ProcDatabase_OutputDataReceived;
            //    _procDatabase.ErrorDataReceived += ProcDatabase_ErrorDataReceived;
            //    _procDatabase.BeginOutputReadLine();
            //    _procDatabase.BeginErrorReadLine();
            //}

            this.OnProcessChanged(LauncherModules.Database, _procDatabase is not null ? LauncherState.Running : LauncherState.Errored);
            return _procDatabase is not null;
        }

        private void ProcDatabase_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            string log = $"{e.Data}";
            XiLog.WriteLine(log, XiLog.XiLogCategory.Database, XiLog.XiLogLevel.Error);
        }

        private void ProcDatabase_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            string log = $"{e.Data}";
            XiLog.WriteLine(log, XiLog.XiLogCategory.Database, XiLog.XiLogLevel.Message);
        }

        public async Task StopDatabase()
        {
            if (_procDatabase is not null)
            {

                this.OnProcessChanged(LauncherModules.Database, LauncherState.Stopping);
                await Task.Delay(16);
                _procDatabase.Kill(true);
                // detach log redirector
                _logDatabaseRedirector.Detach();
                // reset reference and dispatch event
                XiLog.WriteLine("Stopped local database.");
                _procDatabase = null;
                await Task.Delay(16);
                this.OnProcessChanged(LauncherModules.Database, LauncherState.Stopped);
            }
        }
    }

}
