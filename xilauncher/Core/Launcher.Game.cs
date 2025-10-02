namespace xilauncher
{
    public partial class Launcher
    {

        /// <summary>
        /// Launches a new instance of the game process (if none was started yet) with the given user
        /// </summary>
        /// <param name="config">the xi loader config (user, pass, server) to use for the game</param>
        /// <returns>true if a process was started, false otherwise</returns>
        private async Task<bool> LaunchGame(XiLoaderUserConfig config)
        {
            if (_procLoader is not null)
                return false;

            this.OnProcessChanged(Modules.Loader, LauncherState.Starting);
            XiLog.WriteLine("Starting game instance...");
            _procLoader = await LaunchAsync(_resources.fileLoaderExe, _resources.dirLoader,
                ProcessParams.Shell(config.ToArguments(), verb: "runas"));
            //true, true, "runas");
            if (_procLoader is not null)
            {
                XiLog.WriteLine("Started loader instance.");
                _procLoader.Exited += LoaderProcess_Exited;
            }
            else XiLog.WriteLine("Loader failed to start!");

            this.OnProcessChanged(Modules.Loader, _procLoader is not null ? LauncherState.Running : LauncherState.Errored);
            return _procLoader is not null;
        }


        /// <summary>
        /// Stops the active instance of the game process
        /// </summary>
        /// <returns>The completed task of killing & resetting the game process instance</returns>
        private async Task StopGame()
        {
            if (await this.StopProcess(_procLoader, Modules.Loader))
                _procLoader = null;
        }

        private async void LoaderProcess_Exited(object? sender, EventArgs e)
        {
            if (sender == _procLoader)
            {
                _procLoader = null;

                XiLog.WriteLine("Xi loader process was exited.");
                await Task.Delay(16);
                this.OnProcessChanged(Modules.Loader, LauncherState.Stopped);
            }
        }

    }
}
