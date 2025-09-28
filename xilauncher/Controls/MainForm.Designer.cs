namespace xilauncher
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            imageListTabs = new ImageList(components);
            bQuit = new Button();
            poisonTabControl1 = new ReaLTaiizor.Controls.PoisonTabControl();
            tabPageLauncher = new ReaLTaiizor.Controls.PoisonTabPage();
            panelTabGame = new ReaLTaiizor.Controls.PoisonPanel();
            poisonPanel2 = new ReaLTaiizor.Controls.PoisonPanel();
            pbQuitLauncher = new ReaLTaiizor.Controls.PoisonButton();
            pbOpenConfigGamepad = new ReaLTaiizor.Controls.PoisonButton();
            pbOpenConfigPlayOnline = new ReaLTaiizor.Controls.PoisonButton();
            poisonLabel7 = new ReaLTaiizor.Controls.PoisonLabel();
            pbOpenConfigGame = new ReaLTaiizor.Controls.PoisonButton();
            panelUserConfig = new ReaLTaiizor.Controls.PoisonPanel();
            pbStartGame = new ReaLTaiizor.Controls.PoisonButton();
            poisonLabel8 = new ReaLTaiizor.Controls.PoisonLabel();
            userConfigControl = new xilauncher.Controls.XiUserConfigControl();
            poisonPanel1 = new ReaLTaiizor.Controls.PoisonPanel();
            pbViewLogDatabase = new ReaLTaiizor.Controls.PoisonButton();
            pbViewLogXiMap = new ReaLTaiizor.Controls.PoisonButton();
            pbViewLogXiWorld = new ReaLTaiizor.Controls.PoisonButton();
            pbViewLogXiSearch = new ReaLTaiizor.Controls.PoisonButton();
            pbViewLogXiConnect = new ReaLTaiizor.Controls.PoisonButton();
            pbStartXiMap = new ReaLTaiizor.Controls.PoisonButton();
            pbStartXiWorld = new ReaLTaiizor.Controls.PoisonButton();
            pbStartXiSearch = new ReaLTaiizor.Controls.PoisonButton();
            pbStartXiConnect = new ReaLTaiizor.Controls.PoisonButton();
            pbStartEnvironment = new ReaLTaiizor.Controls.PoisonButton();
            pbStartDatabase = new ReaLTaiizor.Controls.PoisonButton();
            poisonLabel3 = new ReaLTaiizor.Controls.PoisonLabel();
            tabPageLogs = new ReaLTaiizor.Controls.PoisonTabPage();
            panelTabLogs = new ReaLTaiizor.Controls.PoisonPanel();
            poisonLabel5 = new ReaLTaiizor.Controls.PoisonLabel();
            pbOpenMapLog = new ReaLTaiizor.Controls.PoisonButton();
            poisonLabel4 = new ReaLTaiizor.Controls.PoisonLabel();
            poisonLabel6 = new ReaLTaiizor.Controls.PoisonLabel();
            pbOpenWorldLog = new ReaLTaiizor.Controls.PoisonButton();
            pbOpenGameLog = new ReaLTaiizor.Controls.PoisonButton();
            pbOpenConnectLog = new ReaLTaiizor.Controls.PoisonButton();
            pbOpenSearchLog = new ReaLTaiizor.Controls.PoisonButton();
            pbOpenDatabaseLog = new ReaLTaiizor.Controls.PoisonButton();
            flowPanelStatusBar = new FlowLayoutPanel();
            poisonLabel2 = new ReaLTaiizor.Controls.PoisonLabel();
            poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            panelStatus = new ReaLTaiizor.Controls.PoisonPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            picStatusGame = new PictureBox();
            picStatusMap = new PictureBox();
            picStatusWorld = new PictureBox();
            picStatusSearch = new PictureBox();
            picStatusConnect = new PictureBox();
            picStatusDatabase = new PictureBox();
            poisonTabControl1.SuspendLayout();
            tabPageLauncher.SuspendLayout();
            panelTabGame.SuspendLayout();
            poisonPanel2.SuspendLayout();
            panelUserConfig.SuspendLayout();
            poisonPanel1.SuspendLayout();
            tabPageLogs.SuspendLayout();
            panelTabLogs.SuspendLayout();
            flowPanelStatusBar.SuspendLayout();
            panelStatus.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStatusGame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStatusMap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStatusWorld).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStatusSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStatusConnect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStatusDatabase).BeginInit();
            SuspendLayout();
            // 
            // imageListTabs
            // 
            imageListTabs.ColorDepth = ColorDepth.Depth32Bit;
            imageListTabs.ImageStream = (ImageListStreamer)resources.GetObject("imageListTabs.ImageStream");
            imageListTabs.TransparentColor = Color.Transparent;
            imageListTabs.Images.SetKeyName(0, "sports_esports_48dp_1F1F1F.png");
            imageListTabs.Images.SetKeyName(1, "settings_48dp_1F1F1F.png");
            imageListTabs.Images.SetKeyName(2, "terminal_48dp_1F1F1F.png");
            imageListTabs.Images.SetKeyName(3, "monitor_heart_48dp_1F1F1F.png");
            imageListTabs.Images.SetKeyName(4, "logout_48dp_1F1F1F.png");
            // 
            // bQuit
            // 
            bQuit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bQuit.BackColor = Color.IndianRed;
            bQuit.Cursor = Cursors.Hand;
            bQuit.FlatAppearance.BorderSize = 0;
            bQuit.FlatStyle = FlatStyle.Flat;
            bQuit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bQuit.ForeColor = SystemColors.HighlightText;
            bQuit.ImageKey = "logout_48dp_1F1F1F.png";
            bQuit.ImageList = imageListTabs;
            bQuit.Location = new Point(757, 13);
            bQuit.Margin = new Padding(2, 27, 2, 2);
            bQuit.Name = "bQuit";
            bQuit.Size = new Size(42, 42);
            bQuit.TabIndex = 28;
            bQuit.UseVisualStyleBackColor = false;
            bQuit.Visible = false;
            bQuit.Click += ButtonQuitLauncher_Click;
            // 
            // poisonTabControl1
            // 
            poisonTabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            poisonTabControl1.Controls.Add(tabPageLauncher);
            poisonTabControl1.Controls.Add(tabPageLogs);
            poisonTabControl1.FontSize = ReaLTaiizor.Extension.Poison.PoisonTabControlSize.Tall;
            poisonTabControl1.FontWeight = ReaLTaiizor.Extension.Poison.PoisonTabControlWeight.Regular;
            poisonTabControl1.HotTrack = true;
            poisonTabControl1.Location = new Point(8, 60);
            poisonTabControl1.Name = "poisonTabControl1";
            poisonTabControl1.Padding = new Point(6, 8);
            poisonTabControl1.SelectedIndex = 0;
            poisonTabControl1.Size = new Size(798, 334);
            poisonTabControl1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Red;
            poisonTabControl1.TabIndex = 29;
            poisonTabControl1.UseSelectable = true;
            poisonTabControl1.UseStyleColors = true;
            // 
            // tabPageLauncher
            // 
            tabPageLauncher.Controls.Add(panelTabGame);
            tabPageLauncher.HorizontalScrollbarBarColor = true;
            tabPageLauncher.HorizontalScrollbarHighlightOnWheel = false;
            tabPageLauncher.HorizontalScrollbarSize = 10;
            tabPageLauncher.Location = new Point(4, 44);
            tabPageLauncher.Name = "tabPageLauncher";
            tabPageLauncher.Padding = new Padding(3);
            tabPageLauncher.Size = new Size(790, 286);
            tabPageLauncher.TabIndex = 0;
            tabPageLauncher.Text = "Launcher";
            tabPageLauncher.VerticalScrollbarBarColor = true;
            tabPageLauncher.VerticalScrollbarHighlightOnWheel = false;
            tabPageLauncher.VerticalScrollbarSize = 10;
            // 
            // panelTabGame
            // 
            panelTabGame.Controls.Add(poisonPanel2);
            panelTabGame.Controls.Add(panelUserConfig);
            panelTabGame.Controls.Add(poisonPanel1);
            panelTabGame.Dock = DockStyle.Fill;
            panelTabGame.HorizontalScrollbarBarColor = true;
            panelTabGame.HorizontalScrollbarHighlightOnWheel = false;
            panelTabGame.HorizontalScrollbarSize = 10;
            panelTabGame.Location = new Point(3, 3);
            panelTabGame.Name = "panelTabGame";
            panelTabGame.Size = new Size(784, 280);
            panelTabGame.TabIndex = 49;
            panelTabGame.VerticalScrollbarBarColor = true;
            panelTabGame.VerticalScrollbarHighlightOnWheel = false;
            panelTabGame.VerticalScrollbarSize = 10;
            // 
            // poisonPanel2
            // 
            poisonPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            poisonPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            poisonPanel2.Controls.Add(pbQuitLauncher);
            poisonPanel2.Controls.Add(pbOpenConfigGamepad);
            poisonPanel2.Controls.Add(pbOpenConfigPlayOnline);
            poisonPanel2.Controls.Add(poisonLabel7);
            poisonPanel2.Controls.Add(pbOpenConfigGame);
            poisonPanel2.HorizontalScrollbarBarColor = true;
            poisonPanel2.HorizontalScrollbarHighlightOnWheel = false;
            poisonPanel2.HorizontalScrollbarSize = 10;
            poisonPanel2.Location = new Point(585, 0);
            poisonPanel2.Name = "poisonPanel2";
            poisonPanel2.Size = new Size(196, 277);
            poisonPanel2.TabIndex = 47;
            poisonPanel2.VerticalScrollbarBarColor = true;
            poisonPanel2.VerticalScrollbarHighlightOnWheel = false;
            poisonPanel2.VerticalScrollbarSize = 10;
            // 
            // pbQuitLauncher
            // 
            pbQuitLauncher.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbQuitLauncher.BackColor = Color.IndianRed;
            pbQuitLauncher.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            pbQuitLauncher.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            pbQuitLauncher.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            pbQuitLauncher.ForeColor = SystemColors.HighlightText;
            pbQuitLauncher.ImeMode = ImeMode.NoControl;
            pbQuitLauncher.Location = new Point(0, 234);
            pbQuitLauncher.Name = "pbQuitLauncher";
            pbQuitLauncher.Size = new Size(196, 42);
            pbQuitLauncher.TabIndex = 46;
            pbQuitLauncher.Text = "Quit";
            pbQuitLauncher.UseCustomBackColor = true;
            pbQuitLauncher.UseCustomForeColor = true;
            pbQuitLauncher.UseSelectable = true;
            pbQuitLauncher.UseVisualStyleBackColor = false;
            pbQuitLauncher.Click += ButtonQuitLauncher_Click;
            // 
            // pbOpenConfigGamepad
            // 
            pbOpenConfigGamepad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbOpenConfigGamepad.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
            pbOpenConfigGamepad.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Medium;
            pbOpenConfigGamepad.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            pbOpenConfigGamepad.ImeMode = ImeMode.NoControl;
            pbOpenConfigGamepad.Location = new Point(0, 69);
            pbOpenConfigGamepad.Name = "pbOpenConfigGamepad";
            pbOpenConfigGamepad.Size = new Size(196, 32);
            pbOpenConfigGamepad.TabIndex = 0;
            pbOpenConfigGamepad.TabStop = false;
            pbOpenConfigGamepad.Text = "  Open Gamepad Config";
            pbOpenConfigGamepad.TextAlign = ContentAlignment.MiddleLeft;
            pbOpenConfigGamepad.UseSelectable = true;
            pbOpenConfigGamepad.Click += OpenGamepadConfigButton_Click;
            // 
            // pbOpenConfigPlayOnline
            // 
            pbOpenConfigPlayOnline.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbOpenConfigPlayOnline.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
            pbOpenConfigPlayOnline.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Medium;
            pbOpenConfigPlayOnline.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            pbOpenConfigPlayOnline.ImeMode = ImeMode.NoControl;
            pbOpenConfigPlayOnline.Location = new Point(0, 107);
            pbOpenConfigPlayOnline.Name = "pbOpenConfigPlayOnline";
            pbOpenConfigPlayOnline.Size = new Size(196, 32);
            pbOpenConfigPlayOnline.TabIndex = 0;
            pbOpenConfigPlayOnline.TabStop = false;
            pbOpenConfigPlayOnline.Text = "  Open PlayOnline Config";
            pbOpenConfigPlayOnline.TextAlign = ContentAlignment.MiddleLeft;
            pbOpenConfigPlayOnline.UseSelectable = true;
            pbOpenConfigPlayOnline.Click += OpenPlayOnlineConfigButton_Click;
            // 
            // poisonLabel7
            // 
            poisonLabel7.AutoSize = true;
            poisonLabel7.Dock = DockStyle.Top;
            poisonLabel7.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            poisonLabel7.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            poisonLabel7.ImeMode = ImeMode.NoControl;
            poisonLabel7.Location = new Point(0, 0);
            poisonLabel7.Name = "poisonLabel7";
            poisonLabel7.Size = new Size(121, 25);
            poisonLabel7.TabIndex = 13;
            poisonLabel7.Text = "Configuration";
            // 
            // pbOpenConfigGame
            // 
            pbOpenConfigGame.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbOpenConfigGame.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
            pbOpenConfigGame.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Medium;
            pbOpenConfigGame.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            pbOpenConfigGame.ImeMode = ImeMode.NoControl;
            pbOpenConfigGame.Location = new Point(0, 31);
            pbOpenConfigGame.Name = "pbOpenConfigGame";
            pbOpenConfigGame.Size = new Size(196, 32);
            pbOpenConfigGame.TabIndex = 0;
            pbOpenConfigGame.TabStop = false;
            pbOpenConfigGame.Text = "  Open Game config";
            pbOpenConfigGame.TextAlign = ContentAlignment.MiddleLeft;
            pbOpenConfigGame.UseSelectable = true;
            pbOpenConfigGame.Click += OpenGameConfigButton_Click;
            // 
            // panelUserConfig
            // 
            panelUserConfig.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelUserConfig.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelUserConfig.Controls.Add(pbStartGame);
            panelUserConfig.Controls.Add(poisonLabel8);
            panelUserConfig.Controls.Add(userConfigControl);
            panelUserConfig.HorizontalScrollbarBarColor = true;
            panelUserConfig.HorizontalScrollbarHighlightOnWheel = false;
            panelUserConfig.HorizontalScrollbarSize = 10;
            panelUserConfig.Location = new Point(3, 0);
            panelUserConfig.Name = "panelUserConfig";
            panelUserConfig.Size = new Size(300, 277);
            panelUserConfig.TabIndex = 48;
            panelUserConfig.VerticalScrollbarBarColor = true;
            panelUserConfig.VerticalScrollbarHighlightOnWheel = false;
            panelUserConfig.VerticalScrollbarSize = 10;
            // 
            // pbStartGame
            // 
            pbStartGame.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbStartGame.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            pbStartGame.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            pbStartGame.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            pbStartGame.ImeMode = ImeMode.NoControl;
            pbStartGame.Location = new Point(0, 234);
            pbStartGame.Margin = new Padding(3, 6, 3, 3);
            pbStartGame.Name = "pbStartGame";
            pbStartGame.Size = new Size(300, 42);
            pbStartGame.TabIndex = 45;
            pbStartGame.Text = "  Launch Game";
            pbStartGame.TextAlign = ContentAlignment.MiddleLeft;
            pbStartGame.UseSelectable = true;
            pbStartGame.Click += ButtonLaunchGame_Click;
            // 
            // poisonLabel8
            // 
            poisonLabel8.AutoSize = true;
            poisonLabel8.Dock = DockStyle.Top;
            poisonLabel8.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            poisonLabel8.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            poisonLabel8.ImeMode = ImeMode.NoControl;
            poisonLabel8.Location = new Point(0, 0);
            poisonLabel8.Name = "poisonLabel8";
            poisonLabel8.Size = new Size(58, 25);
            poisonLabel8.TabIndex = 13;
            poisonLabel8.Text = "Game";
            // 
            // userConfigControl
            // 
            userConfigControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userConfigControl.AutoSize = true;
            userConfigControl.Location = new Point(0, 31);
            userConfigControl.Margin = new Padding(0);
            userConfigControl.Name = "userConfigControl";
            userConfigControl.Size = new Size(300, 197);
            userConfigControl.TabIndex = 46;
            // 
            // poisonPanel1
            // 
            poisonPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            poisonPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            poisonPanel1.Controls.Add(pbViewLogDatabase);
            poisonPanel1.Controls.Add(pbViewLogXiMap);
            poisonPanel1.Controls.Add(pbViewLogXiWorld);
            poisonPanel1.Controls.Add(pbViewLogXiSearch);
            poisonPanel1.Controls.Add(pbViewLogXiConnect);
            poisonPanel1.Controls.Add(pbStartXiMap);
            poisonPanel1.Controls.Add(pbStartXiWorld);
            poisonPanel1.Controls.Add(pbStartXiSearch);
            poisonPanel1.Controls.Add(pbStartXiConnect);
            poisonPanel1.Controls.Add(pbStartEnvironment);
            poisonPanel1.Controls.Add(pbStartDatabase);
            poisonPanel1.Controls.Add(poisonLabel3);
            poisonPanel1.HorizontalScrollbarBarColor = true;
            poisonPanel1.HorizontalScrollbarHighlightOnWheel = false;
            poisonPanel1.HorizontalScrollbarSize = 10;
            poisonPanel1.Location = new Point(309, 0);
            poisonPanel1.Name = "poisonPanel1";
            poisonPanel1.Size = new Size(270, 277);
            poisonPanel1.TabIndex = 39;
            poisonPanel1.VerticalScrollbarBarColor = true;
            poisonPanel1.VerticalScrollbarHighlightOnWheel = false;
            poisonPanel1.VerticalScrollbarSize = 10;
            // 
            // pbViewLogDatabase
            // 
            pbViewLogDatabase.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbViewLogDatabase.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            pbViewLogDatabase.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            pbViewLogDatabase.ImeMode = ImeMode.NoControl;
            pbViewLogDatabase.Location = new Point(226, 31);
            pbViewLogDatabase.Name = "pbViewLogDatabase";
            pbViewLogDatabase.Size = new Size(44, 42);
            pbViewLogDatabase.TabIndex = 0;
            pbViewLogDatabase.TabStop = false;
            pbViewLogDatabase.Text = "Log";
            pbViewLogDatabase.UseSelectable = true;
            pbViewLogDatabase.Click += OpenLogDatabaseButton_Click;
            // 
            // pbViewLogXiMap
            // 
            pbViewLogXiMap.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbViewLogXiMap.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            pbViewLogXiMap.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            pbViewLogXiMap.ImeMode = ImeMode.NoControl;
            pbViewLogXiMap.Location = new Point(226, 244);
            pbViewLogXiMap.Name = "pbViewLogXiMap";
            pbViewLogXiMap.Size = new Size(44, 32);
            pbViewLogXiMap.TabIndex = 0;
            pbViewLogXiMap.TabStop = false;
            pbViewLogXiMap.Text = "Log";
            pbViewLogXiMap.UseSelectable = true;
            pbViewLogXiMap.Click += OpenLogXiMapButton_Click;
            // 
            // pbViewLogXiWorld
            // 
            pbViewLogXiWorld.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbViewLogXiWorld.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            pbViewLogXiWorld.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            pbViewLogXiWorld.ImeMode = ImeMode.NoControl;
            pbViewLogXiWorld.Location = new Point(226, 206);
            pbViewLogXiWorld.Margin = new Padding(2, 3, 2, 3);
            pbViewLogXiWorld.Name = "pbViewLogXiWorld";
            pbViewLogXiWorld.Size = new Size(44, 32);
            pbViewLogXiWorld.TabIndex = 0;
            pbViewLogXiWorld.TabStop = false;
            pbViewLogXiWorld.Text = "Log";
            pbViewLogXiWorld.UseSelectable = true;
            pbViewLogXiWorld.Click += OpenLogXiWorldButton_Click;
            // 
            // pbViewLogXiSearch
            // 
            pbViewLogXiSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbViewLogXiSearch.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            pbViewLogXiSearch.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            pbViewLogXiSearch.ImeMode = ImeMode.NoControl;
            pbViewLogXiSearch.Location = new Point(226, 168);
            pbViewLogXiSearch.Margin = new Padding(2, 3, 2, 3);
            pbViewLogXiSearch.Name = "pbViewLogXiSearch";
            pbViewLogXiSearch.Size = new Size(44, 32);
            pbViewLogXiSearch.TabIndex = 0;
            pbViewLogXiSearch.TabStop = false;
            pbViewLogXiSearch.Text = "Log";
            pbViewLogXiSearch.UseSelectable = true;
            pbViewLogXiSearch.Click += OpenLogXiSearchButton_Click;
            // 
            // pbViewLogXiConnect
            // 
            pbViewLogXiConnect.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbViewLogXiConnect.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            pbViewLogXiConnect.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            pbViewLogXiConnect.ImeMode = ImeMode.NoControl;
            pbViewLogXiConnect.Location = new Point(226, 130);
            pbViewLogXiConnect.Name = "pbViewLogXiConnect";
            pbViewLogXiConnect.Size = new Size(44, 32);
            pbViewLogXiConnect.TabIndex = 0;
            pbViewLogXiConnect.TabStop = false;
            pbViewLogXiConnect.Text = "Log";
            pbViewLogXiConnect.UseSelectable = true;
            pbViewLogXiConnect.Click += OpenLogXiConnectButton_Click;
            // 
            // pbStartXiMap
            // 
            pbStartXiMap.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbStartXiMap.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
            pbStartXiMap.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Medium;
            pbStartXiMap.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            pbStartXiMap.ImeMode = ImeMode.NoControl;
            pbStartXiMap.Location = new Point(24, 244);
            pbStartXiMap.Name = "pbStartXiMap";
            pbStartXiMap.Padding = new Padding(32, 0, 0, 0);
            pbStartXiMap.Size = new Size(196, 32);
            pbStartXiMap.TabIndex = 0;
            pbStartXiMap.TabStop = false;
            pbStartXiMap.Text = "  Launch Xi Map";
            pbStartXiMap.TextAlign = ContentAlignment.MiddleLeft;
            pbStartXiMap.UseSelectable = true;
            pbStartXiMap.UseVisualStyleBackColor = false;
            pbStartXiMap.Click += ButtonLaunchXiMap_Click;
            // 
            // pbStartXiWorld
            // 
            pbStartXiWorld.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbStartXiWorld.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
            pbStartXiWorld.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Medium;
            pbStartXiWorld.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            pbStartXiWorld.ImeMode = ImeMode.NoControl;
            pbStartXiWorld.Location = new Point(24, 206);
            pbStartXiWorld.Name = "pbStartXiWorld";
            pbStartXiWorld.Padding = new Padding(32, 0, 0, 0);
            pbStartXiWorld.Size = new Size(196, 32);
            pbStartXiWorld.TabIndex = 0;
            pbStartXiWorld.TabStop = false;
            pbStartXiWorld.Text = "  Launch Xi World";
            pbStartXiWorld.TextAlign = ContentAlignment.MiddleLeft;
            pbStartXiWorld.UseSelectable = true;
            pbStartXiWorld.UseVisualStyleBackColor = false;
            pbStartXiWorld.Click += ButtonLaunchXiWorld_Click;
            // 
            // pbStartXiSearch
            // 
            pbStartXiSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbStartXiSearch.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
            pbStartXiSearch.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Medium;
            pbStartXiSearch.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            pbStartXiSearch.ImeMode = ImeMode.NoControl;
            pbStartXiSearch.Location = new Point(24, 168);
            pbStartXiSearch.Name = "pbStartXiSearch";
            pbStartXiSearch.Padding = new Padding(32, 0, 0, 0);
            pbStartXiSearch.Size = new Size(196, 32);
            pbStartXiSearch.TabIndex = 0;
            pbStartXiSearch.TabStop = false;
            pbStartXiSearch.Text = "  Launch XI Search";
            pbStartXiSearch.TextAlign = ContentAlignment.MiddleLeft;
            pbStartXiSearch.UseSelectable = true;
            pbStartXiSearch.UseVisualStyleBackColor = false;
            pbStartXiSearch.Click += ButtonLaunchXiSearch_Click;
            // 
            // pbStartXiConnect
            // 
            pbStartXiConnect.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbStartXiConnect.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
            pbStartXiConnect.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Medium;
            pbStartXiConnect.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            pbStartXiConnect.ImeMode = ImeMode.NoControl;
            pbStartXiConnect.Location = new Point(24, 130);
            pbStartXiConnect.Name = "pbStartXiConnect";
            pbStartXiConnect.Padding = new Padding(32, 0, 0, 0);
            pbStartXiConnect.Size = new Size(196, 32);
            pbStartXiConnect.TabIndex = 0;
            pbStartXiConnect.TabStop = false;
            pbStartXiConnect.Text = "  Launch XI Connect";
            pbStartXiConnect.TextAlign = ContentAlignment.MiddleLeft;
            pbStartXiConnect.UseSelectable = true;
            pbStartXiConnect.UseVisualStyleBackColor = false;
            pbStartXiConnect.Click += ButtonLaunchXiConnect_Click;
            // 
            // pbStartEnvironment
            // 
            pbStartEnvironment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbStartEnvironment.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            pbStartEnvironment.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            pbStartEnvironment.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            pbStartEnvironment.ImeMode = ImeMode.NoControl;
            pbStartEnvironment.Location = new Point(0, 82);
            pbStartEnvironment.Margin = new Padding(3, 6, 3, 3);
            pbStartEnvironment.Name = "pbStartEnvironment";
            pbStartEnvironment.Size = new Size(270, 42);
            pbStartEnvironment.TabIndex = 46;
            pbStartEnvironment.Text = "  Launch Environment";
            pbStartEnvironment.TextAlign = ContentAlignment.MiddleLeft;
            pbStartEnvironment.UseCustomBackColor = true;
            pbStartEnvironment.UseSelectable = true;
            pbStartEnvironment.UseVisualStyleBackColor = false;
            pbStartEnvironment.Click += ButtonLaunchEnvironment_Click;
            // 
            // pbStartDatabase
            // 
            pbStartDatabase.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbStartDatabase.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            pbStartDatabase.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            pbStartDatabase.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            pbStartDatabase.ImeMode = ImeMode.NoControl;
            pbStartDatabase.Location = new Point(0, 31);
            pbStartDatabase.Margin = new Padding(3, 6, 3, 3);
            pbStartDatabase.Name = "pbStartDatabase";
            pbStartDatabase.Size = new Size(220, 42);
            pbStartDatabase.TabIndex = 45;
            pbStartDatabase.Text = "  Launch Database";
            pbStartDatabase.TextAlign = ContentAlignment.MiddleLeft;
            pbStartDatabase.UseSelectable = true;
            pbStartDatabase.Click += ButtonLaunchDatabase_Click;
            // 
            // poisonLabel3
            // 
            poisonLabel3.AutoSize = true;
            poisonLabel3.Dock = DockStyle.Top;
            poisonLabel3.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            poisonLabel3.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            poisonLabel3.ImeMode = ImeMode.NoControl;
            poisonLabel3.Location = new Point(0, 0);
            poisonLabel3.Name = "poisonLabel3";
            poisonLabel3.Size = new Size(112, 25);
            poisonLabel3.TabIndex = 13;
            poisonLabel3.Text = "Environment";
            // 
            // tabPageLogs
            // 
            tabPageLogs.Controls.Add(panelTabLogs);
            tabPageLogs.HorizontalScrollbarBarColor = true;
            tabPageLogs.HorizontalScrollbarHighlightOnWheel = false;
            tabPageLogs.HorizontalScrollbarSize = 10;
            tabPageLogs.Location = new Point(4, 35);
            tabPageLogs.Name = "tabPageLogs";
            tabPageLogs.Padding = new Padding(3);
            tabPageLogs.Size = new Size(790, 295);
            tabPageLogs.TabIndex = 2;
            tabPageLogs.Text = "Logs";
            tabPageLogs.UseVisualStyleBackColor = true;
            tabPageLogs.VerticalScrollbarBarColor = true;
            tabPageLogs.VerticalScrollbarHighlightOnWheel = false;
            tabPageLogs.VerticalScrollbarSize = 10;
            // 
            // panelTabLogs
            // 
            panelTabLogs.Controls.Add(poisonLabel5);
            panelTabLogs.Controls.Add(pbOpenMapLog);
            panelTabLogs.Controls.Add(poisonLabel4);
            panelTabLogs.Controls.Add(poisonLabel6);
            panelTabLogs.Controls.Add(pbOpenWorldLog);
            panelTabLogs.Controls.Add(pbOpenGameLog);
            panelTabLogs.Controls.Add(pbOpenConnectLog);
            panelTabLogs.Controls.Add(pbOpenSearchLog);
            panelTabLogs.Controls.Add(pbOpenDatabaseLog);
            panelTabLogs.Dock = DockStyle.Fill;
            panelTabLogs.HorizontalScrollbarBarColor = true;
            panelTabLogs.HorizontalScrollbarHighlightOnWheel = false;
            panelTabLogs.HorizontalScrollbarSize = 10;
            panelTabLogs.Location = new Point(3, 3);
            panelTabLogs.Name = "panelTabLogs";
            panelTabLogs.Size = new Size(784, 289);
            panelTabLogs.TabIndex = 31;
            panelTabLogs.VerticalScrollbarBarColor = true;
            panelTabLogs.VerticalScrollbarHighlightOnWheel = false;
            panelTabLogs.VerticalScrollbarSize = 10;
            // 
            // poisonLabel5
            // 
            poisonLabel5.AutoSize = true;
            poisonLabel5.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            poisonLabel5.ImeMode = ImeMode.NoControl;
            poisonLabel5.Location = new Point(199, 0);
            poisonLabel5.Name = "poisonLabel5";
            poisonLabel5.Size = new Size(82, 25);
            poisonLabel5.TabIndex = 29;
            poisonLabel5.Text = "Database";
            poisonLabel5.Visible = false;
            // 
            // pbOpenMapLog
            // 
            pbOpenMapLog.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            pbOpenMapLog.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            pbOpenMapLog.ImeMode = ImeMode.NoControl;
            pbOpenMapLog.Location = new Point(588, 106);
            pbOpenMapLog.Name = "pbOpenMapLog";
            pbOpenMapLog.Size = new Size(190, 42);
            pbOpenMapLog.TabIndex = 27;
            pbOpenMapLog.Text = "Xi Map Logs";
            pbOpenMapLog.UseSelectable = true;
            pbOpenMapLog.Visible = false;
            pbOpenMapLog.Click += OpenLogXiMapButton_Click;
            // 
            // poisonLabel4
            // 
            poisonLabel4.AutoSize = true;
            poisonLabel4.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            poisonLabel4.Location = new Point(3, 78);
            poisonLabel4.Name = "poisonLabel4";
            poisonLabel4.Size = new Size(161, 25);
            poisonLabel4.TabIndex = 28;
            poisonLabel4.Text = "Server Environment";
            poisonLabel4.Visible = false;
            // 
            // poisonLabel6
            // 
            poisonLabel6.AutoSize = true;
            poisonLabel6.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            poisonLabel6.ImeMode = ImeMode.NoControl;
            poisonLabel6.Location = new Point(3, 0);
            poisonLabel6.Name = "poisonLabel6";
            poisonLabel6.Size = new Size(57, 25);
            poisonLabel6.TabIndex = 30;
            poisonLabel6.Text = "Game";
            poisonLabel6.Visible = false;
            // 
            // pbOpenWorldLog
            // 
            pbOpenWorldLog.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            pbOpenWorldLog.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            pbOpenWorldLog.ImeMode = ImeMode.NoControl;
            pbOpenWorldLog.Location = new Point(393, 106);
            pbOpenWorldLog.Margin = new Padding(2, 3, 2, 3);
            pbOpenWorldLog.Name = "pbOpenWorldLog";
            pbOpenWorldLog.Size = new Size(190, 42);
            pbOpenWorldLog.TabIndex = 26;
            pbOpenWorldLog.Text = "Xi World Logs";
            pbOpenWorldLog.UseSelectable = true;
            pbOpenWorldLog.Visible = false;
            pbOpenWorldLog.Click += OpenLogXiWorldButton_Click;
            // 
            // pbOpenGameLog
            // 
            pbOpenGameLog.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            pbOpenGameLog.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            pbOpenGameLog.ImeMode = ImeMode.NoControl;
            pbOpenGameLog.Location = new Point(3, 28);
            pbOpenGameLog.Name = "pbOpenGameLog";
            pbOpenGameLog.Size = new Size(190, 42);
            pbOpenGameLog.TabIndex = 23;
            pbOpenGameLog.Text = "Xi Loader Logs";
            pbOpenGameLog.UseSelectable = true;
            pbOpenGameLog.Visible = false;
            // 
            // pbOpenConnectLog
            // 
            pbOpenConnectLog.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            pbOpenConnectLog.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            pbOpenConnectLog.ImeMode = ImeMode.NoControl;
            pbOpenConnectLog.Location = new Point(3, 106);
            pbOpenConnectLog.Name = "pbOpenConnectLog";
            pbOpenConnectLog.Size = new Size(190, 42);
            pbOpenConnectLog.TabIndex = 24;
            pbOpenConnectLog.Text = "Xi Connect Logs";
            pbOpenConnectLog.UseSelectable = true;
            pbOpenConnectLog.Visible = false;
            pbOpenConnectLog.Click += OpenLogXiConnectButton_Click;
            // 
            // pbOpenSearchLog
            // 
            pbOpenSearchLog.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            pbOpenSearchLog.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            pbOpenSearchLog.ImeMode = ImeMode.NoControl;
            pbOpenSearchLog.Location = new Point(199, 106);
            pbOpenSearchLog.Margin = new Padding(2, 3, 2, 3);
            pbOpenSearchLog.Name = "pbOpenSearchLog";
            pbOpenSearchLog.Size = new Size(190, 42);
            pbOpenSearchLog.TabIndex = 25;
            pbOpenSearchLog.Text = "Xi Search Logs";
            pbOpenSearchLog.UseSelectable = true;
            pbOpenSearchLog.Visible = false;
            pbOpenSearchLog.Click += OpenLogXiSearchButton_Click;
            // 
            // pbOpenDatabaseLog
            // 
            pbOpenDatabaseLog.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            pbOpenDatabaseLog.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            pbOpenDatabaseLog.Location = new Point(199, 28);
            pbOpenDatabaseLog.Name = "pbOpenDatabaseLog";
            pbOpenDatabaseLog.Size = new Size(192, 42);
            pbOpenDatabaseLog.TabIndex = 22;
            pbOpenDatabaseLog.Text = "Database Logs";
            pbOpenDatabaseLog.UseSelectable = true;
            pbOpenDatabaseLog.Visible = false;
            pbOpenDatabaseLog.Click += OpenLogDatabaseButton_Click;
            // 
            // flowPanelStatusBar
            // 
            flowPanelStatusBar.AutoSize = true;
            flowPanelStatusBar.Controls.Add(poisonLabel2);
            flowPanelStatusBar.Controls.Add(poisonLabel1);
            flowPanelStatusBar.Dock = DockStyle.Bottom;
            flowPanelStatusBar.Location = new Point(8, 400);
            flowPanelStatusBar.Name = "flowPanelStatusBar";
            flowPanelStatusBar.Size = new Size(798, 25);
            flowPanelStatusBar.TabIndex = 32;
            // 
            // poisonLabel2
            // 
            poisonLabel2.AutoSize = true;
            poisonLabel2.Dock = DockStyle.Bottom;
            poisonLabel2.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            poisonLabel2.ImeMode = ImeMode.NoControl;
            poisonLabel2.Location = new Point(3, 0);
            poisonLabel2.Name = "poisonLabel2";
            poisonLabel2.Size = new Size(101, 25);
            poisonLabel2.TabIndex = 32;
            poisonLabel2.Text = "Active Root:";
            // 
            // poisonLabel1
            // 
            poisonLabel1.AutoSize = true;
            poisonLabel1.Dock = DockStyle.Bottom;
            poisonLabel1.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            poisonLabel1.ImeMode = ImeMode.NoControl;
            poisonLabel1.Location = new Point(110, 0);
            poisonLabel1.Name = "poisonLabel1";
            poisonLabel1.Size = new Size(109, 25);
            poisonLabel1.TabIndex = 33;
            poisonLabel1.Text = "poisonLabel1";
            // 
            // panelStatus
            // 
            panelStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelStatus.Controls.Add(flowLayoutPanel1);
            panelStatus.HorizontalScrollbarBarColor = true;
            panelStatus.HorizontalScrollbarHighlightOnWheel = false;
            panelStatus.HorizontalScrollbarSize = 10;
            panelStatus.Location = new Point(573, 75);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(227, 24);
            panelStatus.TabIndex = 33;
            panelStatus.VerticalScrollbarBarColor = true;
            panelStatus.VerticalScrollbarHighlightOnWheel = false;
            panelStatus.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(picStatusGame);
            flowLayoutPanel1.Controls.Add(picStatusMap);
            flowLayoutPanel1.Controls.Add(picStatusWorld);
            flowLayoutPanel1.Controls.Add(picStatusSearch);
            flowLayoutPanel1.Controls.Add(picStatusConnect);
            flowLayoutPanel1.Controls.Add(picStatusDatabase);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(227, 24);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // picStatusGame
            // 
            picStatusGame.BackColor = Color.IndianRed;
            picStatusGame.BorderStyle = BorderStyle.FixedSingle;
            picStatusGame.Image = Properties.Resources.videogame_asset_48dp_F1F1F1;
            picStatusGame.Location = new Point(203, 0);
            picStatusGame.Margin = new Padding(12, 0, 0, 0);
            picStatusGame.Name = "picStatusGame";
            picStatusGame.Size = new Size(24, 24);
            picStatusGame.SizeMode = PictureBoxSizeMode.Zoom;
            picStatusGame.TabIndex = 12;
            picStatusGame.TabStop = false;
            // 
            // picStatusMap
            // 
            picStatusMap.BackColor = Color.IndianRed;
            picStatusMap.BorderStyle = BorderStyle.FixedSingle;
            picStatusMap.Image = Properties.Resources.map_48dp_F1F1F1;
            picStatusMap.Location = new Point(167, 0);
            picStatusMap.Margin = new Padding(12, 0, 0, 0);
            picStatusMap.Name = "picStatusMap";
            picStatusMap.Size = new Size(24, 24);
            picStatusMap.SizeMode = PictureBoxSizeMode.Zoom;
            picStatusMap.TabIndex = 13;
            picStatusMap.TabStop = false;
            // 
            // picStatusWorld
            // 
            picStatusWorld.BackColor = Color.IndianRed;
            picStatusWorld.BorderStyle = BorderStyle.FixedSingle;
            picStatusWorld.Image = Properties.Resources.globe_48dp_F1F1F1;
            picStatusWorld.Location = new Point(131, 0);
            picStatusWorld.Margin = new Padding(12, 0, 0, 0);
            picStatusWorld.Name = "picStatusWorld";
            picStatusWorld.Size = new Size(24, 24);
            picStatusWorld.SizeMode = PictureBoxSizeMode.Zoom;
            picStatusWorld.TabIndex = 14;
            picStatusWorld.TabStop = false;
            // 
            // picStatusSearch
            // 
            picStatusSearch.BackColor = Color.IndianRed;
            picStatusSearch.BorderStyle = BorderStyle.FixedSingle;
            picStatusSearch.Image = Properties.Resources.database_search_48dp_F1F1F1;
            picStatusSearch.Location = new Point(95, 0);
            picStatusSearch.Margin = new Padding(12, 0, 0, 0);
            picStatusSearch.Name = "picStatusSearch";
            picStatusSearch.Size = new Size(24, 24);
            picStatusSearch.SizeMode = PictureBoxSizeMode.Zoom;
            picStatusSearch.TabIndex = 15;
            picStatusSearch.TabStop = false;
            // 
            // picStatusConnect
            // 
            picStatusConnect.BackColor = Color.IndianRed;
            picStatusConnect.BorderStyle = BorderStyle.FixedSingle;
            picStatusConnect.Image = Properties.Resources.router_48dp_F1F1F1;
            picStatusConnect.Location = new Point(59, 0);
            picStatusConnect.Margin = new Padding(12, 0, 0, 0);
            picStatusConnect.Name = "picStatusConnect";
            picStatusConnect.Size = new Size(24, 24);
            picStatusConnect.SizeMode = PictureBoxSizeMode.Zoom;
            picStatusConnect.TabIndex = 16;
            picStatusConnect.TabStop = false;
            // 
            // picStatusDatabase
            // 
            picStatusDatabase.BackColor = Color.IndianRed;
            picStatusDatabase.BorderStyle = BorderStyle.FixedSingle;
            picStatusDatabase.Image = Properties.Resources.data_table_48dp_F1F1F1;
            picStatusDatabase.Location = new Point(23, 0);
            picStatusDatabase.Margin = new Padding(12, 0, 0, 0);
            picStatusDatabase.Name = "picStatusDatabase";
            picStatusDatabase.Size = new Size(24, 24);
            picStatusDatabase.SizeMode = PictureBoxSizeMode.Zoom;
            picStatusDatabase.TabIndex = 17;
            picStatusDatabase.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(814, 428);
            ControlBox = false;
            Controls.Add(panelStatus);
            Controls.Add(flowPanelStatusBar);
            Controls.Add(bQuit);
            Controls.Add(poisonTabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "MainForm";
            Padding = new Padding(8, 60, 8, 3);
            Resizable = false;
            Style = ReaLTaiizor.Enum.Poison.ColorStyle.Red;
            Text = "XI Launcher - FFXI Server Environment";
            poisonTabControl1.ResumeLayout(false);
            tabPageLauncher.ResumeLayout(false);
            panelTabGame.ResumeLayout(false);
            poisonPanel2.ResumeLayout(false);
            poisonPanel2.PerformLayout();
            panelUserConfig.ResumeLayout(false);
            panelUserConfig.PerformLayout();
            poisonPanel1.ResumeLayout(false);
            poisonPanel1.PerformLayout();
            tabPageLogs.ResumeLayout(false);
            panelTabLogs.ResumeLayout(false);
            panelTabLogs.PerformLayout();
            flowPanelStatusBar.ResumeLayout(false);
            flowPanelStatusBar.PerformLayout();
            panelStatus.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picStatusGame).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStatusMap).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStatusWorld).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStatusSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStatusConnect).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStatusDatabase).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imageListTabs;
        private Button bQuit;
        private ReaLTaiizor.Controls.PoisonTabControl poisonTabControl1;
        private ReaLTaiizor.Controls.PoisonTabPage tabPageLauncher;
        private ReaLTaiizor.Controls.PoisonTabPage tabPageLogs;
        private FlowLayoutPanel flowPanelStatusBar;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel2;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private ReaLTaiizor.Controls.PoisonButton pbOpenDatabaseLog;
        private ReaLTaiizor.Controls.PoisonButton pbOpenGameLog;
        private ReaLTaiizor.Controls.PoisonButton pbOpenMapLog;
        private ReaLTaiizor.Controls.PoisonButton pbOpenWorldLog;
        private ReaLTaiizor.Controls.PoisonButton pbOpenSearchLog;
        private ReaLTaiizor.Controls.PoisonButton pbOpenConnectLog;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel6;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel5;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel4;
        private ReaLTaiizor.Controls.PoisonPanel poisonPanel1;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel3;
        private ReaLTaiizor.Controls.PoisonButton pbOpenConfigGame;
        private ReaLTaiizor.Controls.PoisonButton pbOpenConfigGamepad;
        private ReaLTaiizor.Controls.PoisonButton pbStartEnvironment;
        private ReaLTaiizor.Controls.PoisonButton pbStartDatabase;
        private ReaLTaiizor.Controls.PoisonButton pbOpenConfigPlayOnline;
        private ReaLTaiizor.Controls.PoisonPanel poisonPanel2;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel7;
        private ReaLTaiizor.Controls.PoisonPanel panelUserConfig;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel8;
        private ReaLTaiizor.Controls.PoisonButton pbStartGame;
        private ReaLTaiizor.Controls.PoisonPanel panelTabGame;
        private ReaLTaiizor.Controls.PoisonButton pbQuitLauncher;
        private Controls.XiUserConfigControl userConfigControl;
        private ReaLTaiizor.Controls.PoisonPanel panelTabLogs;
        private ReaLTaiizor.Controls.PoisonPanel panelStatus;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox picStatusGame;
        private PictureBox picStatusMap;
        private PictureBox picStatusWorld;
        private PictureBox picStatusSearch;
        private PictureBox picStatusConnect;
        private PictureBox picStatusDatabase;
        private ReaLTaiizor.Controls.PoisonButton pbStartXiMap;
        private ReaLTaiizor.Controls.PoisonButton pbStartXiWorld;
        private ReaLTaiizor.Controls.PoisonButton pbStartXiSearch;
        private ReaLTaiizor.Controls.PoisonButton pbStartXiConnect;
        private ReaLTaiizor.Controls.PoisonButton pbViewLogXiMap;
        private ReaLTaiizor.Controls.PoisonButton pbViewLogXiWorld;
        private ReaLTaiizor.Controls.PoisonButton pbViewLogXiSearch;
        private ReaLTaiizor.Controls.PoisonButton pbViewLogXiConnect;
        private ReaLTaiizor.Controls.PoisonButton pbViewLogDatabase;
    }
}
