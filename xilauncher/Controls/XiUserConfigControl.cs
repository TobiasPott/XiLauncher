namespace xilauncher.Controls
{
    public partial class XiUserConfigControl : UserControl
    {

        public string Username => textBoxUsername.Text.Trim();
        public string Password => textBoxPassword.Text.Trim();
        public bool CreateAccount => toggleCreateAccount.Checked;
        public string Server => textBoxServer.Text.Trim();
        public bool Hairpin => toggleHairpin.Checked;

        public XiUserConfigControl()
        {
            InitializeComponent();
        }

        public void SetConfig(XiLoaderUserConfig config)
        {
            textBoxUsername.Text = config.Username;
            textBoxPassword.Text = new System.Net.NetworkCredential(string.Empty, config.Password).Password;
            toggleCreateAccount.Checked = config.CreateAccount; 
            textBoxServer.Text = config.Server;
            toggleHairpin.Checked = config.UseHairPin;
        }
        public void GetConfig(ref XiLoaderUserConfig config)
        {
            config.Username = textBoxUsername.Text;
            config.Password.Clear();
            config.CreateAccount = toggleCreateAccount.Checked;
            foreach (char c in textBoxPassword.Text) config.Password.AppendChar(c);
            config.Server = textBoxServer.Text;
            config.UseHairPin = toggleHairpin.Checked;
        }

    }
}
