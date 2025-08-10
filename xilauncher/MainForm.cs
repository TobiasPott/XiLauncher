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

        private void LaunchGame()
        {
            if (_launcher.LaunchGame(_default))
            {
                buttonLaunchGame.Text = UITexts.ButtonLabel_StopGame;
            }
            else
            {
                buttonLaunchGame.Text = UITexts.ButtonLabel_LaunchGame;
            }

        }


        private void CloseApplication()
        {
            _launcher.Exit(true, true, true);
            this.Close();
        }

        private async void ButtonLaunchGame_Click(object sender, EventArgs e)
        {
            this.LaunchGame();
            await Task.CompletedTask;
        }
        private async void ButtonLaunchEnvironment_Click(object sender, EventArgs e)
        {
            if (_launcher.IsEnvironmentActive)
            {
                _launcher.StopServer();
                buttonLaunchEnvironment.Text = UITexts.ButtonLabel_StopServer;
            }
            else if (await _launcher.LaunchServer())
            {
                buttonLaunchEnvironment.Text = UITexts.ButtonLabel_LaunchServer;
            }
            await Task.CompletedTask;
        }
        private async void ButtonLaunchDatabase_Click(object sender, EventArgs e)
        {
            if (_launcher.IsDatabaseProcessActive)
            {
                _launcher.StopDatabase();
                buttonLaunchDatabase.Text = UITexts.ButtonLabel_LaunchDatabase;
            }
            else if (await _launcher.LaunchDatabase())
            {
                buttonLaunchDatabase.Text = UITexts.ButtonLabel_StopDatabase;
            }

            //await this.LaunchDatabase();
            await Task.CompletedTask;
        }

        private async void ButtonQuitLauncher_Click(object sender, EventArgs e)
        {
            this.CloseApplication();
            await Task.CompletedTask;
        }

    }
}

