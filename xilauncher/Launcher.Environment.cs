namespace xilauncher
{
    public partial class Launcher
    {
        public bool IsEnvironmentActive => _procConnect is not null
                    && _procSearch is not null
                    && _procWorld is not null
                    && _procMap is not null;

        // ToDo: add CancellationToken argument to allow cancellation of launching all processes
        //          the Task.Delay calls introduce delay in execution which can result in processes started though others are killed via UI already
        
        public async Task<bool> LaunchServer()
        {
            if (_procConnect is null)
            {
                XiLog.WriteLine("Starting server's xi_connect...");
                _procConnect = await LaunchAsync(_resources.fileConnectExe, "", _resources.dirServer);
                if (_procConnect is not null)
                {
                    XiLog.WriteLine("...xi_connect is running.");
                    await Task.Delay(250);
                }
                else XiLog.WriteLine("...failed to start!");
            }
            if (_procSearch is null)
            {
                XiLog.WriteLine("Starting server's xi_search...");
                _procSearch = await LaunchAsync(_resources.fileSearchExe, "", _resources.dirServer);
                if (_procSearch is not null)
                {
                    XiLog.WriteLine("...xi_search is running.");
                    await Task.Delay(250);
                }
                else XiLog.WriteLine("...failed to start!");
            }
            if (_procWorld is null)
            {
                XiLog.WriteLine("Starting server's xi_world...");
                _procWorld = await LaunchAsync(_resources.fileWorldExe, "", _resources.dirServer);
                if (_procWorld is not null)
                {
                    XiLog.WriteLine("...xi_world is running.");
                    await Task.Delay(1250);
                }
                else XiLog.WriteLine("...failed to start!");
            }
            if (_procMap is null)
            {
                XiLog.WriteLine("Starting server's xi_map...");
                _procMap = await LaunchAsync(_resources.fileMapExe, "", _resources.dirServer);
                if (_procMap is not null)
                {
                    XiLog.WriteLine("...xi_map is running.");
                    //await Task.Delay(250);
                }
                else XiLog.WriteLine("...failed to start!");
            }
            return IsDatabaseProcessActive;
        }

        public void StopServer()
        {
            if (_procMap is not null)
            {
                _procMap.Kill(true);
                _procMap = null;
                XiLog.WriteLine("Stopped xi_map server.");
            }
            if (_procWorld is not null)
            {
                _procWorld.Kill(true);
                _procWorld = null;
                XiLog.WriteLine("Stopped xi_world server.");
            }
            if (_procSearch is not null)
            {
                _procSearch.Kill(true);
                _procSearch = null;
                XiLog.WriteLine("Stopped xi_search server.");
            }
            if (_procConnect is not null)
            {
                _procConnect.Kill(true);
                _procConnect = null;
                XiLog.WriteLine("Stopped xi_connect server.");
            }
        }

    }
}
