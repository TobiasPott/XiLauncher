using xilauncher.Properties;

namespace xilauncher
{
    public partial class MainForm : Form
    {
        private Launcher _launcher;
        private XiLoaderConfig _default = new XiLoaderConfig("mule", "private", "127.0.0.1", true);


        public MainForm(Launcher launcher) : base()
        {
            InitializeComponent();
            //_ = new Input();
            _launcher = launcher;
            _launcher.ProcessChanged += Launcher_ProcessChanged;
            xiUserConfigControl.SetConfig(_default);
        }

        private async Task CloseApplication()
        {
            _launcher.ProcessChanged -= Launcher_ProcessChanged;
            await _launcher.Exit(true, true, true);
            this.Close();
        }
        private void Launcher_ProcessChanged(LauncherModules modules, LauncherState state)
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

        }

        // ToDo: covnert click function body to functions in Launcher.Database/Environment files
        //      as async void callable with cancellation token
        private async void ButtonLaunchGame_Click(object sender, EventArgs e)
        {
            if (_launcher.IsGameActive)
            {
                _launcher.StopGame();
                buttonLaunchGame.Text = UITexts.ButtonLabel_LaunchGame;
                buttonLaunchGame.Image = Resources.red_x32;
            }
            else
            {
                buttonLaunchGame.Image = Resources.yellow_x32;
                xiUserConfigControl.GetConfig(ref _default);
                if (_launcher.LaunchGame(_default))
                {
                    buttonLaunchGame.Text = UITexts.ButtonLabel_StopGame;
                    buttonLaunchGame.Image = Resources.green_x32;
                }
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
            await this.CloseApplication();
            await Task.CompletedTask;
        }

    }
}

