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

        public bool IsXiConnectActive => _procConnect is not null;
        public bool IsXiSearchActive => _procSearch is not null;
        public bool IsXiWorldActive => _procWorld is not null;
        public bool IsXiMapActive => _procMap is not null;
        public bool IsXiConnectAvailable => _resources.IsXiConnectAvailable;
        public bool IsXiSearchAvailable => _resources.IsXiSearchAvailable;
        public bool IsXiWorldAvailable => _resources.IsXiWorldAvailable;
        public bool IsXiMapAvailable => _resources.IsXiMapAvailable;
        /// <summary>
        /// 
        /// Launches a new instances of each environment process (if none was started yet).
        /// The launch pauses in between processes to allow them to chain up with less chance to error
        /// </summary>
        /// <param name="cancellationToken">token to cancel the launch process during startup</param>
        /// <returns>true if a processes were started, false otherwise</returns>
        public async Task<bool> LaunchEnvironment(CancellationToken cancellationToken = default)
        {
            this.OnProcessChanged(LauncherModules.Environment, LauncherState.Starting);
            await LaunchXiConnectServer(cancellationToken);
            await Task.Delay(1000, cancellationToken);
            await LaunchXiSearchServer(cancellationToken);
            await Task.Delay(1000, cancellationToken);
            await LaunchXiWorldServer(cancellationToken);
            await Task.Delay(1000, cancellationToken);
            await LaunchXiMapServer(cancellationToken);
            this.OnProcessChanged(LauncherModules.Environment, LauncherState.Running);

            // stop all processes already running (in order) is cancelled
            if (cancellationToken.IsCancellationRequested)
            {
                await StopEnvironment();
            }

            return IsDatabaseProcessActive;
        }

        public async Task<bool> LaunchXiMapServer(CancellationToken cancellationToken)
        {
            if (_procMap is null)
            {
                this.OnProcessChanged(LauncherModules.XiMap, LauncherState.Starting);
                XiLog.WriteLine("Starting server's xi_map...");
                if (!cancellationToken.IsCancellationRequested)
                {
                    _procMap = await LaunchAsync(_resources.fileMapExe, "", _resources.dirServer,
                        true, false, "", true);
                    if (_procMap is not null)
                    {
                        XiLog.WriteLine("...xi_map is running.");
                        XiLogProcessRedirector.XiMapRedirector.Attach(_procMap);
                        this.OnProcessChanged(LauncherModules.XiMap, LauncherState.Running);
                        return true;
                    }
                    else XiLog.WriteLine("...failed to start!");
                }
            }
            return false;
        }
        public async Task<bool> LaunchXiWorldServer(CancellationToken cancellationToken)
        {
            if (_procWorld is null)
            {
                this.OnProcessChanged(LauncherModules.XiWorld, LauncherState.Starting);
                XiLog.WriteLine("Starting server's xi_world...");
                if (!cancellationToken.IsCancellationRequested)
                {
                    _procWorld = await LaunchAsync(_resources.fileWorldExe, "", _resources.dirServer,
                        true, false, "", true);
                    if (_procWorld is not null)
                    {
                        XiLog.WriteLine("...xi_world is running.");
                        XiLogProcessRedirector.XiWorldRedirector.Attach(_procWorld);
                        this.OnProcessChanged(LauncherModules.XiWorld, LauncherState.Running);
                        return true;
                    }
                    else XiLog.WriteLine("...failed to start!");
                }
            }
            return false;
        }
        public async Task<bool> LaunchXiSearchServer(CancellationToken cancellationToken)
        {
            if (_procSearch is null)
            {
                this.OnProcessChanged(LauncherModules.XiSearch, LauncherState.Starting);
                XiLog.WriteLine("Starting server's xi_search...");
                if (!cancellationToken.IsCancellationRequested)
                {
                    _procSearch = await LaunchAsync(_resources.fileSearchExe, "", _resources.dirServer,
                        true, false, "", true);
                    if (_procSearch is not null)
                    {
                        XiLog.WriteLine("...xi_search is running.");
                        XiLogProcessRedirector.XiSearchRedirector.Attach(_procSearch);
                        this.OnProcessChanged(LauncherModules.XiSearch, LauncherState.Running);
                        return true;
                    }
                    else XiLog.WriteLine("...failed to start!");
                }
            }
            return false;
        }
        public async Task<bool> LaunchXiConnectServer(CancellationToken cancellationToken)
        {
            if (_procConnect is null)
            {
                this.OnProcessChanged(LauncherModules.XiConnect, LauncherState.Starting);
                XiLog.WriteLine("Starting server's xi_connect...");
                if (!cancellationToken.IsCancellationRequested)
                {
                    _procConnect = await LaunchAsync(_resources.fileConnectExe, "", _resources.dirServer,
                        true, false, "", true);
                    if (_procConnect is not null)
                    {
                        XiLog.WriteLine("...xi_connect is running.");
                        XiLogProcessRedirector.XiConnectRedirector.Attach(_procConnect);
                        this.OnProcessChanged(LauncherModules.XiConnect, LauncherState.Running);
                        return true;
                    }
                    else XiLog.WriteLine("...failed to start!");
                }
            }
            return false;
        }

        /// <summary>
        /// Stops the active instances of the environment processes
        /// </summary>
        /// <returns>The completed task of killing & resetting the environment process instances</returns>
        public async Task StopEnvironment()
        {
            this.OnProcessChanged(LauncherModules.Environment, LauncherState.Stopping);
            await StopXiMapServer();
            await Task.Delay(200);
            await StopXiWorldServer();
            await Task.Delay(200);
            await StopXiSearchServer();
            await Task.Delay(200);
            await StopXiConnectServer();
            this.OnProcessChanged(LauncherModules.Environment, LauncherState.Stopped);
        }

        public async Task StopXiConnectServer()
        {
            if (_procConnect is not null)
            {
                _procConnect.Kill(true);
                _procConnect = null;
                XiLogProcessRedirector.XiConnectRedirector.Detach();
                await Task.Delay(33);
                this.OnProcessChanged(LauncherModules.XiConnect, LauncherState.Stopped);
                XiLog.WriteLine("Stopped xi_connect server.");
            }
        }
        public async Task StopXiSearchServer()
        {
            if (_procSearch is not null)
            {
                _procSearch.Kill(true);
                _procSearch = null;
                XiLogProcessRedirector.XiSearchRedirector.Detach();
                await Task.Delay(33);
                this.OnProcessChanged(LauncherModules.XiSearch, LauncherState.Stopped);
                XiLog.WriteLine("Stopped xi_search server.");
            }
        }
        public async Task StopXiWorldServer()
        {
            if (_procWorld is not null)
            {
                _procWorld.Kill(true);
                _procWorld = null;
                XiLogProcessRedirector.XiWorldRedirector.Detach();
                await Task.Delay(33);
                this.OnProcessChanged(LauncherModules.XiWorld, LauncherState.Stopped);
                XiLog.WriteLine("Stopped xi_world server.");
            }
        }
        public async Task StopXiMapServer()
        {
            if (_procMap is not null)
            {
                _procMap.Kill(true);
                _procMap = null;
                XiLogProcessRedirector.XiMapRedirector.Detach();
                await Task.Delay(33);
                this.OnProcessChanged(LauncherModules.XiMap, LauncherState.Stopped);
                XiLog.WriteLine("Stopped xi_map server.");
            }
        }

    }
}
