using xilauncher.Properties;

namespace xilauncher
{
    /*
    HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\PlayOnlineUS\SquareEnix\PlayOnlineViewer
    HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\PlayOnlineUS\SquareEnix\PlayOnlineViewer\Settings

    FullScreen 			0   (?? 0 or 1) 
    Language			1   (?? unclear)
    PlayAudio			1   (?? 0 or 1)
    PlayOpeningMovie	1   (?? 0 or 1)
    ResetSettings		0   (?? 0 or 1)
    SupportLanguage		1   (?? unclear)
    UseGameController	0   (?? 0 or 1)
    WindowH				480 (?? width in pixel)
    WindowW				640 (?? height in pixel)
    WindowX				256 (?? x position on screen)
    WindowY				256 (?? x position on screen)
        */
    public partial class MainForm : Form
    {
        private Launcher _launcher;
        private XiLoaderUserConfig _default = new XiLoaderUserConfig("mule", "private", "127.0.0.1", true);


        public MainForm(Launcher launcher) : base()
        {
            InitializeComponent();
            //_ = new Input();
            _launcher = launcher;
            _launcher.ProcessChanged += Launcher_ProcessChanged;
            _launcher.Resources.Refreshed += Resources_Refreshed;
            xiUserConfigControl.SetConfig(_default);

            _launcher.Resources.RefreshResources();


        }

        private void Resources_Refreshed()
        {
            tsslBaseDir.Text = _launcher.Resources.dirBase.FullName;
            XiLog.WriteLine("Refreshed to: " + _launcher.Resources.dirBase.FullName);
        }

        private async Task CloseApplication()
        {
            _launcher.ProcessChanged -= Launcher_ProcessChanged;
            await _launcher.Exit(true, true, true);
            this.Close();
        }
        private void Launcher_ProcessChanged(LauncherModules modules, LauncherState state)
        {
            this.Invoke(new Action(() =>
            {
                if (modules.HasFlag(LauncherModules.Database))
                {
                    switch (state)
                    {
                        case LauncherState.Starting:
                            buttonLaunchDatabase.Text = UITexts.ButtonLabel_StopDatabase;
                            buttonLaunchDatabase.Image = Resources.yellow_x32;
                            break;

                        case LauncherState.Running:
                            buttonLaunchDatabase.Text = UITexts.ButtonLabel_StopDatabase;
                            buttonLaunchDatabase.Image = Resources.green_x32;
                            break;

                        case LauncherState.Stopping:
                            buttonLaunchDatabase.Text = UITexts.ButtonLabel_StopDatabase;
                            buttonLaunchDatabase.Image = Resources.yellow_x32;
                            break;

                        case LauncherState.Stopped:
                            buttonLaunchDatabase.Text = UITexts.ButtonLabel_LaunchDatabase;
                            buttonLaunchDatabase.Image = Resources.red_x32;
                            break;

                    }

                }
                if (modules.HasFlag(LauncherModules.Environment))
                {
                    switch (state)
                    {
                        case LauncherState.Starting:
                            buttonLaunchEnvironment.Text = UITexts.ButtonLabel_StopServer;
                            buttonLaunchEnvironment.Image = Resources.yellow_x32;
                            break;

                        case LauncherState.Running:
                            buttonLaunchEnvironment.Text = UITexts.ButtonLabel_StopServer;
                            buttonLaunchEnvironment.Image = Resources.green_x32;
                            break;

                        case LauncherState.Stopping:
                            buttonLaunchEnvironment.Text = UITexts.ButtonLabel_StopServer;
                            buttonLaunchEnvironment.Image = Resources.yellow_x32;
                            break;

                        case LauncherState.Stopped:
                            buttonLaunchEnvironment.Text = UITexts.ButtonLabel_LaunchServer;
                            buttonLaunchEnvironment.Image = Resources.red_x32;
                            break;

                    }

                }
                if (modules.HasFlag(LauncherModules.Loader))
                {
                    switch (state)
                    {
                        case LauncherState.Starting:
                            buttonLaunchGame.Text = UITexts.ButtonLabel_StopGame;
                            buttonLaunchGame.Image = Resources.yellow_x32;
                            break;

                        case LauncherState.Running:
                            buttonLaunchGame.Text = UITexts.ButtonLabel_StopGame;
                            buttonLaunchGame.Image = Resources.green_x32;
                            break;

                        case LauncherState.Stopping:
                            buttonLaunchGame.Text = UITexts.ButtonLabel_StopGame;
                            buttonLaunchGame.Image = Resources.yellow_x32;
                            break;

                        case LauncherState.Stopped:
                            buttonLaunchGame.Text = UITexts.ButtonLabel_LaunchGame;
                            buttonLaunchGame.Image = Resources.red_x32;
                            break;

                    }

                }
            }));
        }

        // ToDo: covnert click function body to functions in Launcher.Database/Environment files
        //      as async void callable with cancellation token
        private async void ButtonLaunchGame_Click(object sender, EventArgs e)
        {
            if (_launcher.IsGameProcessActive)
            {
                await _launcher.StopGame();
            }
            else if (await _launcher.LaunchGame(_default))
            {
            }
            await Task.CompletedTask;
        }
        private async void ButtonLaunchEnvironment_Click(object sender, EventArgs e)
        {
            if (_launcher.IsEnvironmentActive)
            {
                await _launcher.StopEnvironment();
            }
            else if (await _launcher.LaunchEnvironment())
            {
            }
            await Task.CompletedTask;
        }
        private async void ButtonLaunchDatabase_Click(object sender, EventArgs e)
        {
            if (_launcher.IsDatabaseProcessActive)
            {
                await _launcher.StopDatabase();
            }
            else if (await _launcher.LaunchDatabase())
            {
            }
            await Task.CompletedTask;
        }

        private async void ButtonQuitLauncher_Click(object sender, EventArgs e)
        {
            // ToDo: only call dialog if servers are running
            DialogResult result = DialogResult.Yes;
            if (_launcher.IsDatabaseProcessActive || _launcher.IsEnvironmentActive
                || _launcher.IsGameProcessActive)
            {
                string message = String.Format($"Processes are still running. {Environment.NewLine}" +
                    $"Game:\t\t{(_launcher.IsGameProcessActive ? "running" : "stopped")}{Environment.NewLine}" +
                    $"Database:\t{(_launcher.IsDatabaseProcessActive ? "running" : "stopped")}{Environment.NewLine}" +
                    $"Server:\t\t{(_launcher.IsEnvironmentActive ? "running" : "stopped")}{Environment.NewLine}" +
                    $"{Environment.NewLine}");
                result = MessageBox.Show(message, "Stop processes and Quit?", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    await this.CloseApplication();
                }
            }
            //DialogResult result = MessageBox.Show("message", "Quit Application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
                await this.CloseApplication();
            await Task.CompletedTask;
        }


        //private void tabLauncher_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string logContent = XiLog.GetLog(XiLog.XiLogCategory.Database);
        //    textBoxMonitor.Text = logContent;
        //    textBoxMonitor.Select(logContent.Length, 0);
        //    textBoxMonitor.ScrollToCaret();
        //}


        Controls.LogForm? logFormDatabase;
        private void button2_Click(object sender, EventArgs e)
        {
            if (logFormDatabase == null)
            {
                logFormDatabase = new Controls.LogForm();
                logFormDatabase.Category = XiLog.XiLogCategory.Database;
                // init log form;
                logFormDatabase.FormClosed += LogFormDatabase_FormClosed;
            }

            logFormDatabase.Show();
        }

        private void LogFormDatabase_FormClosed(object? sender, FormClosedEventArgs e)
        {
            //logFormDatabase?.Dispose();
            logFormDatabase = null;
        }
    }
}

