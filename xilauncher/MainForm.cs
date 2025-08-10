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
            xiUserConfigControl.SetConfig(_default);
        }

        private void CloseApplication()
        {
            _launcher.Exit(true, true, true);
            this.Close();
        }

        // ToDo: covnert click function body to functions in Launcher.Database/Environment files
        //      as async void callable with cancellation token
        private async void ButtonLaunchGame_Click(object sender, EventArgs e)
        {
            if (_launcher.IsEnvironmentActive)
            {
                _launcher.StopEnvironment();
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
                _launcher.StopEnvironment();
                buttonLaunchEnvironment.Text = UITexts.ButtonLabel_LaunchServer;
                buttonLaunchEnvironment.Image = Resources.red_x32;
            }
            else
            {
                buttonLaunchEnvironment.Image = Resources.yellow_x32;
                if (await _launcher.LaunchEnvironment())
                {
                    buttonLaunchEnvironment.Text = UITexts.ButtonLabel_StopServer;
                    buttonLaunchEnvironment.Image = Resources.green_x32;
                }
            }
            await Task.CompletedTask;
        }
        private async void ButtonLaunchDatabase_Click(object sender, EventArgs e)
        {
            if (_launcher.IsDatabaseProcessActive)
            {
                _launcher.StopDatabase();
                buttonLaunchDatabase.Text = UITexts.ButtonLabel_LaunchDatabase;
                buttonLaunchDatabase.Image = Resources.red_x32;
            }
            else
            {
                buttonLaunchDatabase.Image = Resources.yellow_x32;
                if (await _launcher.LaunchDatabase())
                {
                    buttonLaunchDatabase.Text = UITexts.ButtonLabel_StopDatabase;
                    buttonLaunchDatabase.Image = Resources.green_x32;
                }
            }
            await Task.CompletedTask;
        }

        private async void ButtonQuitLauncher_Click(object sender, EventArgs e)
        {
            this.CloseApplication();
            await Task.CompletedTask;
        }

    }
}

