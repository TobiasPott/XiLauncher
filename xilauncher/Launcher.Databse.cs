namespace xilauncher
{
    internal partial class Launcher
    {
        private bool EnsureDatabaseConfig()
        {
            if (_resources.fileMyIni is not null && _resources.fileMyIni.Exists
                && _resources.dirMysqlData is not null
                && _resources.dirMysqlPlugins is not null)
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
                        myIniLines[i] = $"plugin-dir={_resources.dirMysqlPlugins.FullName}";
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

        public bool LaunchDatabase()
        {
            if (_procDatabase is not null)
                return false;

            Console.WriteLine("Starting local database...");
            if (!EnsureDatabaseConfig())
                return false;
            if (!EnsureDatabaseEnvironmentVariable())
                return false;

            _procDatabase = Launch(_resources.fileMysqldExe, xiMariadbArgs, _resources.dirMariadb);
            if (_procDatabase is not null) Console.WriteLine("Started local database.");
            else Console.WriteLine("Database failed to start!");

            return _procDatabase is not null;
        }
        private void StopDatabase()
        {
            if (_procDatabase is not null)
            {
                _procDatabase.Kill(true);
                Console.WriteLine("Stopped local database.");
            }
        }
    }
}
