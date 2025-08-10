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
            xiUserControl2.SetConfig(_default);
        }

        private void LaunchGame()
        {
            if (_launcher.LaunchGame(_default))
            {
            }

        }
        private void LaunchEnvironment()
        {
            if (_launcher.LaunchServer())
            {
            }

        }

        private void LaunchDatabase()
        {
            // optional for now, focus on game and environment launching (what the powershell scripts do)
            if (_launcher.LaunchDatabase())
            {
            }
        }

        private void CloseApplication()
        {
            _launcher.Exit(true, true, true);
            this.Close();
        }

        private void ButtonLaunchGame_Click(object sender, EventArgs e)
        {
            this.LaunchGame();
        }
        private void ButtonLaunchEnvironment_Click(object sender, EventArgs e)
        {
            this.LaunchEnvironment();
        }
        private void ButtonQuitLauncher_Click(object sender, EventArgs e)
        {
            this.CloseApplication();
        }

        private void ButtonLaunchDatabase_Click(object sender, EventArgs e)
        {
            this.LaunchDatabase();
        }
    }
}

