namespace xilauncher
{
    public partial class Launcher
    {
        /// <summary>
        /// returns whether or not the game/xiloader process started by the launcher was started already
        /// </summary>
        public bool IsLoaderProcessActive => _procLoader is not null;
        public bool IsLoaderAvailable => _resources.IsLoaderAvailable;

        /// <summary>
        /// Launches a new instance of the game process (if none was started yet) with the given user
        /// </summary>
        /// <param name="config">the xi loader config (user, pass, server) to use for the game</param>
        /// <returns>true if a process was started, false otherwise</returns>
        public async Task<bool> LaunchGame(XiLoaderUserConfig config)
        {
            if (_procLoader is not null)
                return false;

            this.OnProcessChanged(LauncherModules.Loader, LauncherState.Starting);
            XiLog.WriteLine("Starting game instance...");
            _procLoader = await LaunchAsync(_resources.fileLoaderExe, config.ToArguments(), _resources.dirLoader,
                true, true, "runas");
            if (_procLoader is not null)
            {
                XiLog.WriteLine("Started loader instance.");
                _procLoader.Exited += LoaderProcess_Exited;
            }
            else XiLog.WriteLine("Loader failed to start!");

            this.OnProcessChanged(LauncherModules.Loader, _procLoader is not null ? LauncherState.Running : LauncherState.Errored);
            return _procLoader is not null;
        }

        /// <summary>
        /// Stops the active instance of the game process
        /// </summary>
        /// <returns>The completed task of killing & resetting the game process instance</returns>
        public async Task StopGame()
        {
            if (_procLoader is not null)
            {
                this.OnProcessChanged(LauncherModules.Loader, LauncherState.Stopping);
                await Task.Delay(16);
                XiLog.WriteLine($"Stopped loader instance (PID:{_procLoader.Id}).");
                _procLoader.Kill(true);
                _procLoader = null;
                await Task.Delay(16);
                this.OnProcessChanged(LauncherModules.Loader, LauncherState.Stopped);
            }
        }

        private async void LoaderProcess_Exited(object? sender, EventArgs e)
        {
            if (sender == _procLoader)
            {
                _procLoader = null;

                XiLog.WriteLine("Xi loader process was exited.");
                await Task.Delay(16);
                this.OnProcessChanged(LauncherModules.Loader, LauncherState.Stopped);
            }
        }

    }
}
