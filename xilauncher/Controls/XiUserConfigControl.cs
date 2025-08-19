namespace xilauncher.Controls
{
    public partial class XiUserConfigControl : UserControl
    {
        [System.ComponentModel.Category("Controls"),
        System.ComponentModel.Description("Specifies whether the controls buttons are visible."),
        System.ComponentModel.DefaultValue(true)]
        public bool ShowButtons
        {
            get => button1.Visible;
            set
            {
                button1.Visible = value;
                Invalidate();
            }
        }

        public string Username => textBoxUsername.Text.Trim();
        public string Password => textBoxPassword.Text.Trim();
        public string Server => textBoxServer.Text.Trim();
        public bool Hairpin => checkBoxHairpin.Checked;

        public XiUserConfigControl()
        {
            InitializeComponent();
        }

        public void SetConfig(XiLoaderUserConfig config)
        {
            textBoxUsername.Text = config.Username;
            textBoxPassword.Text = new System.Net.NetworkCredential(string.Empty, config.Password).Password;
            textBoxServer.Text = config.Server;
            checkBoxHairpin.Checked = config.UseHairPin;
        }
        public void GetConfig(ref XiLoaderUserConfig config)
        {
            config.Username = textBoxUsername.Text;
            config.Password.Clear();
            foreach (char c in textBoxPassword.Text) config.Password.AppendChar(c);
            config.Server = textBoxServer.Text;
            config.UseHairPin = checkBoxHairpin.Checked;
        }
    }
}
