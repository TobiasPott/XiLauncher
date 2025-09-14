namespace xilauncher
{
    public partial class Launcher
    {
        /// <summary>
        /// returns whether or not the environment processes started by the launcher were started already
        /// </summary>
        public bool IsEnvironmentActive => _procConnect is not null
                    && _procSearch is not null
                    && _procWorld is not null
                    && _procMap is not null;

        /// <summary>
        /// Launches a new instances of the each environment process (if none was started yet).
        /// The launch pauses inbetween processes to allow them to chain up with less chance to error
        /// </summary>
        /// <param name="cancellationToken">token to cancel the launch process during startup</param>
        /// <returns>true if a processes were started, false otherwise</returns>
        public async Task<bool> LaunchEnvironment(CancellationToken cancellationToken = default)
        {
            this.OnProcessChanged(LauncherModules.Environment, LauncherState.Starting);
            await LaunchConnectServer(cancellationToken);
            await Task.Delay(1000);
            await LaunchSearchServer(cancellationToken);
            await Task.Delay(1000);
            await LaunchWorldServer(cancellationToken);
            await Task.Delay(1000);
            await LaunchMapServer(cancellationToken);
            this.OnProcessChanged(LauncherModules.Environment, LauncherState.Running);

            // stop all processes already running (in order) is cancelled
            if (cancellationToken.IsCancellationRequested)
            {
                await StopEnvironment();
            }

            return IsDatabaseProcessActive;
        }

        private async Task LaunchMapServer(CancellationToken cancellationToken)
        {
            if (_procMap is null)
            {
                this.OnProcessChanged(LauncherModules.MapServer, LauncherState.Starting);
                XiLog.WriteLine("Starting server's xi_map...");
                if (!cancellationToken.IsCancellationRequested)
                {
                    _procMap = await LaunchAsync(_resources.fileMapExe, "", _resources.dirServer,
                        true, false, "", true);
                    if (_procMap is not null)
                    {
                        XiLog.WriteLine("...xi_map is running.");
                        XiLogProcessRedirector.XiMapRedirector.Attach(_procMap);
                        this.OnProcessChanged(LauncherModules.MapServer, LauncherState.Running);
                    }
                    else XiLog.WriteLine("...failed to start!");
                }
            }
        }
        private async Task LaunchWorldServer(CancellationToken cancellationToken)
        {
            if (_procWorld is null)
            {
                this.OnProcessChanged(LauncherModules.WorldServer, LauncherState.Starting);
                XiLog.WriteLine("Starting server's xi_world...");
                if (!cancellationToken.IsCancellationRequested)
                {
                    _procWorld = await LaunchAsync(_resources.fileWorldExe, "", _resources.dirServer,
                        true, false, "", true);
                    if (_procWorld is not null)
                    {
                        XiLog.WriteLine("...xi_world is running.");
                        XiLogProcessRedirector.XiWorldRedirector.Attach(_procWorld);
                        this.OnProcessChanged(LauncherModules.WorldServer, LauncherState.Running);
                    }
                    else XiLog.WriteLine("...failed to start!");
                }
            }
        }
        private async Task LaunchSearchServer(CancellationToken cancellationToken)
        {
            if (_procSearch is null)
            {
                this.OnProcessChanged(LauncherModules.SearchServer, LauncherState.Starting);
                XiLog.WriteLine("Starting server's xi_search...");
                if (!cancellationToken.IsCancellationRequested)
                {
                    _procSearch = await LaunchAsync(_resources.fileSearchExe, "", _resources.dirServer,
                        true, false, "", true);
                    if (_procSearch is not null)
                    {
                        XiLog.WriteLine("...xi_search is running.");
                        XiLogProcessRedirector.XiSearchRedirector.Attach(_procSearch);
                        this.OnProcessChanged(LauncherModules.SearchServer, LauncherState.Running);
                    }
                    else XiLog.WriteLine("...failed to start!");
                }
            }
        }
        private async Task LaunchConnectServer(CancellationToken cancellationToken)
        {
            if (_procConnect is null)
            {
                this.OnProcessChanged(LauncherModules.ConnectServer, LauncherState.Starting);
                XiLog.WriteLine("Starting server's xi_connect...");
                if (!cancellationToken.IsCancellationRequested)
                {
                    _procConnect = await LaunchAsync(_resources.fileConnectExe, "", _resources.dirServer,
                        true, false, "", true);
                    if (_procConnect is not null)
                    {
                        XiLog.WriteLine("...xi_connect is running.");
                        XiLogProcessRedirector.XiConnectRedirector.Attach(_procConnect);
                        this.OnProcessChanged(LauncherModules.ConnectServer, LauncherState.Running);
                    }
                    else XiLog.WriteLine("...failed to start!");
                }
            }
        }

        /// <summary>
        /// Stops the active instances of the environment processes
        /// </summary>
        /// <returns>The completed task of killing & resetting the environment process instances</returns>
        public async Task StopEnvironment()
        {
            this.OnProcessChanged(LauncherModules.Environment, LauncherState.Stopping);
            await StopMapServer();
            await Task.Delay(200);
            await StopWorldServer();
            await Task.Delay(200);
            await StopSearchServer();
            await Task.Delay(200);
            await StopConnectServer();
            this.OnProcessChanged(LauncherModules.Environment, LauncherState.Stopped);
        }

        private async Task StopConnectServer()
        {
            if (_procConnect is not null)
            {
                _procConnect.Kill(true);
                _procConnect = null;
                XiLogProcessRedirector.XiConnectRedirector.Detach();
                await Task.Delay(33);
                this.OnProcessChanged(LauncherModules.ConnectServer, LauncherState.Stopped);
                XiLog.WriteLine("Stopped xi_connect server.");
            }
        }
        private async Task StopSearchServer()
        {
            if (_procSearch is not null)
            {
                _procSearch.Kill(true);
                _procSearch = null;
                XiLogProcessRedirector.XiSearchRedirector.Detach();
                await Task.Delay(33);
                this.OnProcessChanged(LauncherModules.SearchServer, LauncherState.Stopped);
                XiLog.WriteLine("Stopped xi_search server.");
            }
        }
        private async Task StopWorldServer()
        {
            if (_procWorld is not null)
            {
                _procWorld.Kill(true);
                _procWorld = null;
                XiLogProcessRedirector.XiWorldRedirector.Detach();
                await Task.Delay(33);
                this.OnProcessChanged(LauncherModules.WorldServer, LauncherState.Stopped);
                XiLog.WriteLine("Stopped xi_world server.");
            }
        }
        private async Task StopMapServer()
        {
            if (_procMap is not null)
            {
                _procMap.Kill(true);
                _procMap = null;
                XiLogProcessRedirector.XiMapRedirector.Detach();
                await Task.Delay(33);
                this.OnProcessChanged(LauncherModules.MapServer, LauncherState.Stopped);
                XiLog.WriteLine("Stopped xi_map server.");
            }
        }

    }
}
