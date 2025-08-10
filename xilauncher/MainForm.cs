namespace xilauncher
{
    public partial class MainForm : Form
    {
        private Launcher _launcher;

        public MainForm()
        {
            InitializeComponent();
            //_ = new Input();
            _launcher = new Launcher();

        }

        private void LaunchGame()
        {

            if (_launcher.LaunchGame())
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

