namespace xilauncher.Controls
{
    public partial class XiUserControl : UserControl
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

        public XiUserControl()
        {
            InitializeComponent();
        }

        public void SetConfig(XiLoaderConfig config)
        {
            textBoxUsername.Text = config.Username;
            textBoxPassword.Text = new System.Net.NetworkCredential(string.Empty, config.Password).Password;
            textBoxServer.Text = config.Server;
            checkBoxHairpin.Checked = config.UseHairPin;
        }
    }
}
