namespace xilauncher
{
    public partial class Launcher
    {

        public bool IsProcessActive(Modules module)
        {
            switch (module)
            {
                case Modules.Default:
                    return false;
                case Modules.Environment:
                    return _procConnect is not null && _procSearch is not null && _procWorld is not null && _procMap is not null;
                case Modules.XiConnect:
                    return _procConnect is not null;
                case Modules.XiSearch:
                    return _procSearch is not null;
                case Modules.XiWorld:
                    return _procWorld is not null;
                case Modules.XiMap:
                    return _procMap is not null;
                case Modules.Database:
                    return _procDatabase is not null;
                case Modules.Loader:
                    return _procLoader is not null;
            }
            return false;
        }

        /// <summary>
        /// 
        /// Launches a new instances of each environment process (if none was started yet).
        /// The launch pauses in between processes to allow them to chain up with less chance to error
        /// </summary>
        /// <param name="cancellationToken">token to cancel the launch process during startup</param>
        /// <returns>true if a processes were started, false otherwise</returns>
        private async Task<bool> LaunchEnvironment(CancellationToken cancellationToken = default)
        {
            this.OnProcessChanged(Modules.Environment, LauncherState.Starting);
            await LaunchXiConnectServer(cancellationToken);
            await Task.Delay(1000, cancellationToken);
            await LaunchXiSearchServer(cancellationToken);
            await Task.Delay(1000, cancellationToken);
            await LaunchXiWorldServer(cancellationToken);
            await Task.Delay(1000, cancellationToken);
            await LaunchXiMapServer(cancellationToken);
            this.OnProcessChanged(Modules.Environment, LauncherState.Running);

            // stop all processes already running (in order) is cancelled
            if (cancellationToken.IsCancellationRequested)
            {
                await StopEnvironment();
            }

            await Task.Delay(100, cancellationToken);
            return IsProcessActive(Modules.Environment);
        }

        private async Task<bool> LaunchXiMapServer(CancellationToken cancellationToken)
        {
            if (_procMap is null)
            {
                this.OnProcessChanged(Modules.XiMap, LauncherState.Starting);
                XiLog.WriteLine("Starting server's xi_map...");
                if (!cancellationToken.IsCancellationRequested)
                {
                    _procMap = await LaunchAsync(_resources.fileMapExe, _resources.dirServer, ProcessParams.Default);
                    //true, false, "", true);
                    if (_procMap is not null)
                    {
                        XiLog.WriteLine("...xi_map is running.");
                        XiLogProcessRedirector.XiMapRedirector.Attach(_procMap);
                        this.OnProcessChanged(Modules.XiMap | Modules.Environment, LauncherState.Running);
                        return true;
                    }
                    else XiLog.WriteLine("...failed to start!");
                }
            }
            return false;
        }
        private async Task<bool> LaunchXiWorldServer(CancellationToken cancellationToken)
        {
            if (_procWorld is null)
            {
                this.OnProcessChanged(Modules.XiWorld, LauncherState.Starting);
                XiLog.WriteLine("Starting server's xi_world...");
                if (!cancellationToken.IsCancellationRequested)
                {
                    _procWorld = await LaunchAsync(_resources.fileWorldExe, _resources.dirServer, ProcessParams.Default);
                    //true, false, "", true);
                    if (_procWorld is not null)
                    {
                        XiLog.WriteLine("...xi_world is running.");
                        XiLogProcessRedirector.XiWorldRedirector.Attach(_procWorld);
                        this.OnProcessChanged(Modules.XiWorld | Modules.Environment, LauncherState.Running);
                        return true;
                    }
                    else XiLog.WriteLine("...failed to start!");
                }
            }
            return false;
        }
        private async Task<bool> LaunchXiSearchServer(CancellationToken cancellationToken)
        {
            if (_procSearch is null)
            {
                this.OnProcessChanged(Modules.XiSearch, LauncherState.Starting);
                XiLog.WriteLine("Starting server's xi_search...");
                if (!cancellationToken.IsCancellationRequested)
                {
                    _procSearch = await LaunchAsync(_resources.fileSearchExe, _resources.dirServer, ProcessParams.Default);
                        //true, false, "", true);
                    if (_procSearch is not null)
                    {
                        XiLog.WriteLine("...xi_search is running.");
                        XiLogProcessRedirector.XiSearchRedirector.Attach(_procSearch);
                        this.OnProcessChanged(Modules.XiSearch | Modules.Environment, LauncherState.Running);
                        return true;
                    }
                    else XiLog.WriteLine("...failed to start!");
                }
            }
            return false;
        }
        private async Task<bool> LaunchXiConnectServer(CancellationToken cancellationToken)
        {
            if (_procConnect is null)
            {
                this.OnProcessChanged(Modules.XiConnect, LauncherState.Starting);
                XiLog.WriteLine("Starting server's xi_connect...");
                if (!cancellationToken.IsCancellationRequested)
                {
                    _procConnect = await LaunchAsync(_resources.fileConnectExe, _resources.dirServer, ProcessParams.Default);
                        //true, false, "", true);
                    if (_procConnect is not null)
                    {
                        XiLog.WriteLine("...xi_connect is running.");
                        XiLogProcessRedirector.XiConnectRedirector.Attach(_procConnect);
                        this.OnProcessChanged(Modules.XiConnect | Modules.Environment, LauncherState.Running);
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
        private async Task StopEnvironment()
        {
            this.OnProcessChanged(Modules.Environment, LauncherState.Stopping);
            await StopXiMapServer();
            await Task.Delay(200);
            await StopXiWorldServer();
            await Task.Delay(200);
            await StopXiSearchServer();
            await Task.Delay(200);
            await StopXiConnectServer();
            this.OnProcessChanged(Modules.Environment, LauncherState.Stopped);
        }

        private async Task StopXiConnectServer()
        {
            if (await this.StopProcess(_procConnect, Modules.XiConnect, XiLogProcessRedirector.XiConnectRedirector))
                _procConnect = null;
        }
        private async Task StopXiSearchServer()
        {
            if (await this.StopProcess(_procSearch, Modules.XiSearch, XiLogProcessRedirector.XiSearchRedirector))
                _procSearch = null;
        }
        private async Task StopXiWorldServer()
        {
            if (await this.StopProcess(_procWorld, Modules.XiWorld, XiLogProcessRedirector.XiWorldRedirector))
                _procWorld = null;
        }
        private async Task StopXiMapServer()
        {
            if (await this.StopProcess(_procMap, Modules.XiMap, XiLogProcessRedirector.XiMapRedirector))
                _procMap = null;
        }

    }
}
