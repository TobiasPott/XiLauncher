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

        public async Task<bool> LaunchEnvironment(CancellationToken cancellationToken = default)
        {
            await LaunchConnectServer(cancellationToken);
            await LaunchSearchServer(cancellationToken);
            await LaunchWorldServer(cancellationToken);
            await LaunchMapServer(cancellationToken);

            // stop all processes already running (in order) is cancelled
            if (cancellationToken.IsCancellationRequested)
            {
                StopEnvironment();
            }

            return IsDatabaseProcessActive;
        }

        private async Task LaunchMapServer(CancellationToken cancellationToken)
        {
            if (_procMap is null)
            {
                XiLog.WriteLine("Starting server's xi_map...");

                if (!cancellationToken.IsCancellationRequested)
                {
                    _procMap = await LaunchAsync(_resources.fileMapExe, "", _resources.dirServer);
                    if (_procMap is not null)
                    {
                        XiLog.WriteLine("...xi_map is running.");
                    }
                    else XiLog.WriteLine("...failed to start!");
                }
            }
        }

        private async Task LaunchWorldServer(CancellationToken cancellationToken)
        {
            if (_procWorld is null)
            {
                XiLog.WriteLine("Starting server's xi_world...");
                if (!cancellationToken.IsCancellationRequested)
                {
                    _procWorld = await LaunchAsync(_resources.fileWorldExe, "", _resources.dirServer);
                    if (_procWorld is not null)
                    {
                        XiLog.WriteLine("...xi_world is running.");
                        await Task.Delay(1500);
                    }
                    else XiLog.WriteLine("...failed to start!");
                }
            }
        }

        private async Task LaunchSearchServer(CancellationToken cancellationToken)
        {
            if (_procSearch is null)
            {
                XiLog.WriteLine("Starting server's xi_search...");
                if (!cancellationToken.IsCancellationRequested)
                {
                    _procSearch = await LaunchAsync(_resources.fileSearchExe, "", _resources.dirServer);
                    if (_procSearch is not null)
                    {
                        XiLog.WriteLine("...xi_search is running.");
                        await Task.Delay(500);
                    }
                    else XiLog.WriteLine("...failed to start!");
                }
            }
        }

        private async Task LaunchConnectServer(CancellationToken cancellationToken)
        {
            if (_procConnect is null)
            {
                XiLog.WriteLine("Starting server's xi_connect...");
                if (!cancellationToken.IsCancellationRequested)
                {
                    _procConnect = await LaunchAsync(_resources.fileConnectExe, "", _resources.dirServer);
                    if (_procConnect is not null)
                    {
                        XiLog.WriteLine("...xi_connect is running.");
                        await Task.Delay(500);
                    }
                    else XiLog.WriteLine("...failed to start!");
                }
            }
        }

        public void StopEnvironment()
        {
            StopMapServer();
            StopWorldServer();
            StopSearchServer();
            StopConnectServer();
        }

        private void StopConnectServer()
        {
            if (_procConnect is not null)
            {
                _procConnect.Kill(true);
                _procConnect = null;
                XiLog.WriteLine("Stopped xi_connect server.");
            }
        }

        private void StopSearchServer()
        {
            if (_procSearch is not null)
            {
                _procSearch.Kill(true);
                _procSearch = null;
                XiLog.WriteLine("Stopped xi_search server.");
            }
        }

        private void StopWorldServer()
        {
            if (_procWorld is not null)
            {
                _procWorld.Kill(true);
                _procWorld = null;
                XiLog.WriteLine("Stopped xi_world server.");
            }
        }

        private void StopMapServer()
        {
            if (_procMap is not null)
            {
                _procMap.Kill(true);
                _procMap = null;
                XiLog.WriteLine("Stopped xi_map server.");
            }
        }
    }
}
