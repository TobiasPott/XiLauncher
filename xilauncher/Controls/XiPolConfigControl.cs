namespace xilauncher.Controls
{
    public partial class XiPolConfigControl : UserControl
    {
        [System.ComponentModel.Category("Controls"),
        System.ComponentModel.Description("Specifies whether the controls buttons are visible."),
        System.ComponentModel.DefaultValue(true)]
        public bool ShowGamepadConfig
        {
            get => buttonConfigGamepad.Visible;
            set
            {
                buttonConfigGamepad.Visible = value;
                Invalidate();
            }
        }

        public XiPolConfigControl()
        {
            InitializeComponent();
        }

        public void SetConfig(XiLoaderUserConfig config)
        {
        }
        public void GetConfig(ref XiLoaderUserConfig config)
        {
        }
    }
}
