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
            tabPage1 = new TabPage();
            panelTabGame = new ReaLTaiizor.Controls.PoisonPanel();
            pbQuitLauncher = new ReaLTaiizor.Controls.PoisonButton();
            poisonPanel2 = new ReaLTaiizor.Controls.PoisonPanel();
            pbOpenConfigGamepad = new ReaLTaiizor.Controls.PoisonButton();
            pbOpenConfigPlayOnline = new ReaLTaiizor.Controls.PoisonButton();
            poisonLabel7 = new ReaLTaiizor.Controls.PoisonLabel();
            pbOpenConfigGame = new ReaLTaiizor.Controls.PoisonButton();
            poisonPanel3 = new ReaLTaiizor.Controls.PoisonPanel();
            pbStartGame = new ReaLTaiizor.Controls.PoisonButton();
            poisonLabel8 = new ReaLTaiizor.Controls.PoisonLabel();
            userConfigControl = new xilauncher.Controls.XiUserConfigControl();
            poisonPanel1 = new ReaLTaiizor.Controls.PoisonPanel();
            pbStartEnvironment = new ReaLTaiizor.Controls.PoisonButton();
            pbStartDatabase = new ReaLTaiizor.Controls.PoisonButton();
            poisonLabel3 = new ReaLTaiizor.Controls.PoisonLabel();
            tabPage3 = new TabPage();
            poisonLabel6 = new ReaLTaiizor.Controls.PoisonLabel();
            poisonLabel5 = new ReaLTaiizor.Controls.PoisonLabel();
            poisonLabel4 = new ReaLTaiizor.Controls.PoisonLabel();
            pbOpenMapLog = new ReaLTaiizor.Controls.PoisonButton();
            pbOpenWorldLog = new ReaLTaiizor.Controls.PoisonButton();
            pbOpenSearchLog = new ReaLTaiizor.Controls.PoisonButton();
            pbOpenConnectLog = new ReaLTaiizor.Controls.PoisonButton();
            pbOpenGameLog = new ReaLTaiizor.Controls.PoisonButton();
            pbOpenDatabaseLog = new ReaLTaiizor.Controls.PoisonButton();
            panelTabLogs = new ReaLTaiizor.Controls.PoisonPanel();
            flowPanelStatusBar = new FlowLayoutPanel();
            poisonLabel2 = new ReaLTaiizor.Controls.PoisonLabel();
            poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            panelStatus = new ReaLTaiizor.Controls.PoisonPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pbStatusGame = new PictureBox();
            pbStatusMap = new PictureBox();
            pbStatusWorld = new PictureBox();
            pbStatusSearch = new PictureBox();
            pbStatusConnect = new PictureBox();
            pbStatusDatabase = new PictureBox();
            poisonTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panelTabGame.SuspendLayout();
            poisonPanel2.SuspendLayout();
            poisonPanel3.SuspendLayout();
            poisonPanel1.SuspendLayout();
            tabPage3.SuspendLayout();
            flowPanelStatusBar.SuspendLayout();
            panelStatus.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbStatusGame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStatusMap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStatusWorld).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStatusSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStatusConnect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStatusDatabase).BeginInit();
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
            bQuit.Location = new Point(768, 13);
            bQuit.Margin = new Padding(2, 27, 2, 2);
            bQuit.Name = "bQuit";
            bQuit.Size = new Size(42, 42);
            bQuit.TabIndex = 28;
            bQuit.UseVisualStyleBackColor = false;
            bQuit.Click += ButtonQuitLauncher_Click;
            // 
            // poisonTabControl1
            // 
            poisonTabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            poisonTabControl1.Controls.Add(tabPage1);
            poisonTabControl1.Controls.Add(tabPage3);
            poisonTabControl1.FontSize = ReaLTaiizor.Extension.Poison.PoisonTabControlSize.Tall;
            poisonTabControl1.FontWeight = ReaLTaiizor.Extension.Poison.PoisonTabControlWeight.Regular;
            poisonTabControl1.HotTrack = true;
            poisonTabControl1.Location = new Point(8, 60);
            poisonTabControl1.Name = "poisonTabControl1";
            poisonTabControl1.Padding = new Point(6, 8);
            poisonTabControl1.SelectedIndex = 0;
            poisonTabControl1.Size = new Size(802, 385);
            poisonTabControl1.TabIndex = 29;
            poisonTabControl1.UseSelectable = true;
            poisonTabControl1.UseStyleColors = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panelTabGame);
            tabPage1.Location = new Point(4, 44);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(794, 337);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Game";
            // 
            // panelTabGame
            // 
            panelTabGame.Controls.Add(pbQuitLauncher);
            panelTabGame.Controls.Add(poisonPanel2);
            panelTabGame.Controls.Add(poisonPanel3);
            panelTabGame.Controls.Add(poisonPanel1);
            panelTabGame.Dock = DockStyle.Fill;
            panelTabGame.HorizontalScrollbarBarColor = true;
            panelTabGame.HorizontalScrollbarHighlightOnWheel = false;
            panelTabGame.HorizontalScrollbarSize = 10;
            panelTabGame.Location = new Point(3, 3);
            panelTabGame.Name = "panelTabGame";
            panelTabGame.Size = new Size(788, 331);
            panelTabGame.TabIndex = 49;
            panelTabGame.VerticalScrollbarBarColor = true;
            panelTabGame.VerticalScrollbarHighlightOnWheel = false;
            panelTabGame.VerticalScrollbarSize = 10;
            // 
            // pbQuitLauncher
            // 
            pbQuitLauncher.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pbQuitLauncher.BackColor = Color.IndianRed;
            pbQuitLauncher.DisplayFocus = true;
            pbQuitLauncher.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            pbQuitLauncher.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            pbQuitLauncher.ForeColor = SystemColors.HighlightText;
            pbQuitLauncher.ImeMode = ImeMode.NoControl;
            pbQuitLauncher.Location = new Point(397, 276);
            pbQuitLauncher.Name = "pbQuitLauncher";
            pbQuitLauncher.Size = new Size(388, 49);
            pbQuitLauncher.TabIndex = 46;
            pbQuitLauncher.Text = "Quit";
            pbQuitLauncher.UseCustomBackColor = true;
            pbQuitLauncher.UseCustomForeColor = true;
            pbQuitLauncher.UseSelectable = true;
            pbQuitLauncher.UseVisualStyleBackColor = false;
            pbQuitLauncher.Click += ButtonQuitLauncher_Click;
            // 
            // poisonPanel2
            // 
            poisonPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            poisonPanel2.Controls.Add(pbOpenConfigGamepad);
            poisonPanel2.Controls.Add(pbOpenConfigPlayOnline);
            poisonPanel2.Controls.Add(poisonLabel7);
            poisonPanel2.Controls.Add(pbOpenConfigGame);
            poisonPanel2.HorizontalScrollbarBarColor = true;
            poisonPanel2.HorizontalScrollbarHighlightOnWheel = false;
            poisonPanel2.HorizontalScrollbarSize = 10;
            poisonPanel2.Location = new Point(397, 168);
            poisonPanel2.Name = "poisonPanel2";
            poisonPanel2.Size = new Size(388, 102);
            poisonPanel2.TabIndex = 47;
            poisonPanel2.VerticalScrollbarBarColor = true;
            poisonPanel2.VerticalScrollbarHighlightOnWheel = false;
            poisonPanel2.VerticalScrollbarSize = 10;
            // 
            // pbOpenConfigGamepad
            // 
            pbOpenConfigGamepad.DisplayFocus = true;
            pbOpenConfigGamepad.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            pbOpenConfigGamepad.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            pbOpenConfigGamepad.ImeMode = ImeMode.NoControl;
            pbOpenConfigGamepad.Location = new Point(195, 28);
            pbOpenConfigGamepad.Name = "pbOpenConfigGamepad";
            pbOpenConfigGamepad.Size = new Size(189, 32);
            pbOpenConfigGamepad.TabIndex = 43;
            pbOpenConfigGamepad.Text = "Gamepad";
            pbOpenConfigGamepad.UseSelectable = true;
            pbOpenConfigGamepad.Click += OpenGamepadConfigButton_Click;
            // 
            // pbOpenConfigPlayOnline
            // 
            pbOpenConfigPlayOnline.DisplayFocus = true;
            pbOpenConfigPlayOnline.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            pbOpenConfigPlayOnline.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            pbOpenConfigPlayOnline.ImeMode = ImeMode.NoControl;
            pbOpenConfigPlayOnline.Location = new Point(0, 66);
            pbOpenConfigPlayOnline.Name = "pbOpenConfigPlayOnline";
            pbOpenConfigPlayOnline.Size = new Size(189, 32);
            pbOpenConfigPlayOnline.TabIndex = 44;
            pbOpenConfigPlayOnline.Text = "PlayOnline";
            pbOpenConfigPlayOnline.UseSelectable = true;
            pbOpenConfigPlayOnline.Click += OpenPlayOnlineConfigButton_Click;
            // 
            // poisonLabel7
            // 
            poisonLabel7.AutoSize = true;
            poisonLabel7.Dock = DockStyle.Top;
            poisonLabel7.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            poisonLabel7.ImeMode = ImeMode.NoControl;
            poisonLabel7.Location = new Point(0, 0);
            poisonLabel7.Name = "poisonLabel7";
            poisonLabel7.Size = new Size(116, 25);
            poisonLabel7.TabIndex = 13;
            poisonLabel7.Text = "Configuration";
            // 
            // pbOpenConfigGame
            // 
            pbOpenConfigGame.DisplayFocus = true;
            pbOpenConfigGame.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            pbOpenConfigGame.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            pbOpenConfigGame.ImeMode = ImeMode.NoControl;
            pbOpenConfigGame.Location = new Point(0, 28);
            pbOpenConfigGame.Name = "pbOpenConfigGame";
            pbOpenConfigGame.Size = new Size(189, 32);
            pbOpenConfigGame.TabIndex = 42;
            pbOpenConfigGame.Text = "Game";
            pbOpenConfigGame.UseSelectable = true;
            pbOpenConfigGame.Click += OpenGameConfigButton_Click;
            // 
            // poisonPanel3
            // 
            poisonPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            poisonPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            poisonPanel3.Controls.Add(pbStartGame);
            poisonPanel3.Controls.Add(poisonLabel8);
            poisonPanel3.Controls.Add(userConfigControl);
            poisonPanel3.HorizontalScrollbarBarColor = true;
            poisonPanel3.HorizontalScrollbarHighlightOnWheel = false;
            poisonPanel3.HorizontalScrollbarSize = 10;
            poisonPanel3.Location = new Point(3, 3);
            poisonPanel3.Name = "poisonPanel3";
            poisonPanel3.Size = new Size(388, 322);
            poisonPanel3.TabIndex = 48;
            poisonPanel3.VerticalScrollbarBarColor = true;
            poisonPanel3.VerticalScrollbarHighlightOnWheel = false;
            poisonPanel3.VerticalScrollbarSize = 10;
            // 
            // pbStartGame
            // 
            pbStartGame.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbStartGame.DisplayFocus = true;
            pbStartGame.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            pbStartGame.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            pbStartGame.ImeMode = ImeMode.NoControl;
            pbStartGame.Location = new Point(2, 273);
            pbStartGame.Name = "pbStartGame";
            pbStartGame.Size = new Size(383, 49);
            pbStartGame.TabIndex = 45;
            pbStartGame.Text = "Launch Game";
            pbStartGame.UseSelectable = true;
            pbStartGame.Click += ButtonLaunchGame_Click;
            // 
            // poisonLabel8
            // 
            poisonLabel8.AutoSize = true;
            poisonLabel8.Dock = DockStyle.Top;
            poisonLabel8.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            poisonLabel8.ImeMode = ImeMode.NoControl;
            poisonLabel8.Location = new Point(0, 0);
            poisonLabel8.Name = "poisonLabel8";
            poisonLabel8.Size = new Size(57, 25);
            poisonLabel8.TabIndex = 13;
            poisonLabel8.Text = "Game";
            // 
            // userConfigControl
            // 
            userConfigControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userConfigControl.AutoSize = true;
            userConfigControl.Location = new Point(0, 27);
            userConfigControl.Margin = new Padding(2);
            userConfigControl.Name = "userConfigControl";
            userConfigControl.Size = new Size(385, 301);
            userConfigControl.TabIndex = 46;
            // 
            // poisonPanel1
            // 
            poisonPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            poisonPanel1.Controls.Add(pbStartEnvironment);
            poisonPanel1.Controls.Add(pbStartDatabase);
            poisonPanel1.Controls.Add(poisonLabel3);
            poisonPanel1.HorizontalScrollbarBarColor = true;
            poisonPanel1.HorizontalScrollbarHighlightOnWheel = false;
            poisonPanel1.HorizontalScrollbarSize = 10;
            poisonPanel1.Location = new Point(397, 3);
            poisonPanel1.Name = "poisonPanel1";
            poisonPanel1.Size = new Size(388, 159);
            poisonPanel1.TabIndex = 39;
            poisonPanel1.VerticalScrollbarBarColor = true;
            poisonPanel1.VerticalScrollbarHighlightOnWheel = false;
            poisonPanel1.VerticalScrollbarSize = 10;
            // 
            // pbStartEnvironment
            // 
            pbStartEnvironment.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbStartEnvironment.DisplayFocus = true;
            pbStartEnvironment.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            pbStartEnvironment.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            pbStartEnvironment.ImeMode = ImeMode.NoControl;
            pbStartEnvironment.Location = new Point(199, 28);
            pbStartEnvironment.Name = "pbStartEnvironment";
            pbStartEnvironment.Size = new Size(186, 49);
            pbStartEnvironment.TabIndex = 46;
            pbStartEnvironment.Text = "Launch Environment";
            pbStartEnvironment.UseCustomBackColor = true;
            pbStartEnvironment.UseSelectable = true;
            pbStartEnvironment.UseVisualStyleBackColor = false;
            pbStartEnvironment.Click += ButtonLaunchEnvironment_Click;
            // 
            // pbStartDatabase
            // 
            pbStartDatabase.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbStartDatabase.DisplayFocus = true;
            pbStartDatabase.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            pbStartDatabase.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            pbStartDatabase.ImeMode = ImeMode.NoControl;
            pbStartDatabase.Location = new Point(0, 28);
            pbStartDatabase.Name = "pbStartDatabase";
            pbStartDatabase.Size = new Size(193, 49);
            pbStartDatabase.TabIndex = 45;
            pbStartDatabase.Text = "Launch Database";
            pbStartDatabase.UseSelectable = true;
            pbStartDatabase.Click += ButtonLaunchDatabase_Click;
            // 
            // poisonLabel3
            // 
            poisonLabel3.AutoSize = true;
            poisonLabel3.Dock = DockStyle.Top;
            poisonLabel3.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            poisonLabel3.ImeMode = ImeMode.NoControl;
            poisonLabel3.Location = new Point(0, 0);
            poisonLabel3.Name = "poisonLabel3";
            poisonLabel3.Size = new Size(108, 25);
            poisonLabel3.TabIndex = 13;
            poisonLabel3.Text = "Environment";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(poisonLabel6);
            tabPage3.Controls.Add(poisonLabel5);
            tabPage3.Controls.Add(poisonLabel4);
            tabPage3.Controls.Add(pbOpenMapLog);
            tabPage3.Controls.Add(pbOpenWorldLog);
            tabPage3.Controls.Add(pbOpenSearchLog);
            tabPage3.Controls.Add(pbOpenConnectLog);
            tabPage3.Controls.Add(pbOpenGameLog);
            tabPage3.Controls.Add(pbOpenDatabaseLog);
            tabPage3.Controls.Add(panelTabLogs);
            tabPage3.Location = new Point(4, 35);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(794, 346);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Logs";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // poisonLabel6
            // 
            poisonLabel6.AutoSize = true;
            poisonLabel6.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            poisonLabel6.ImeMode = ImeMode.NoControl;
            poisonLabel6.Location = new Point(6, 179);
            poisonLabel6.Name = "poisonLabel6";
            poisonLabel6.Size = new Size(57, 25);
            poisonLabel6.TabIndex = 30;
            poisonLabel6.Text = "Game";
            // 
            // poisonLabel5
            // 
            poisonLabel5.AutoSize = true;
            poisonLabel5.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            poisonLabel5.ImeMode = ImeMode.NoControl;
            poisonLabel5.Location = new Point(6, 3);
            poisonLabel5.Name = "poisonLabel5";
            poisonLabel5.Size = new Size(82, 25);
            poisonLabel5.TabIndex = 29;
            poisonLabel5.Text = "Database";
            // 
            // poisonLabel4
            // 
            poisonLabel4.AutoSize = true;
            poisonLabel4.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            poisonLabel4.Location = new Point(6, 92);
            poisonLabel4.Name = "poisonLabel4";
            poisonLabel4.Size = new Size(161, 25);
            poisonLabel4.TabIndex = 28;
            poisonLabel4.Text = "Server Environment";
            // 
            // pbOpenMapLog
            // 
            pbOpenMapLog.DisplayFocus = true;
            pbOpenMapLog.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            pbOpenMapLog.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            pbOpenMapLog.Highlight = true;
            pbOpenMapLog.ImeMode = ImeMode.NoControl;
            pbOpenMapLog.Location = new Point(594, 127);
            pbOpenMapLog.Name = "pbOpenMapLog";
            pbOpenMapLog.Size = new Size(192, 49);
            pbOpenMapLog.TabIndex = 27;
            pbOpenMapLog.Text = "Xi Map Console";
            pbOpenMapLog.UseSelectable = true;
            pbOpenMapLog.Click += OpenLogXiMapButton_Click;
            // 
            // pbOpenWorldLog
            // 
            pbOpenWorldLog.DisplayFocus = true;
            pbOpenWorldLog.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            pbOpenWorldLog.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            pbOpenWorldLog.Highlight = true;
            pbOpenWorldLog.ImeMode = ImeMode.NoControl;
            pbOpenWorldLog.Location = new Point(400, 127);
            pbOpenWorldLog.Margin = new Padding(2, 3, 2, 3);
            pbOpenWorldLog.Name = "pbOpenWorldLog";
            pbOpenWorldLog.Size = new Size(192, 49);
            pbOpenWorldLog.TabIndex = 26;
            pbOpenWorldLog.Text = "Xi World Console";
            pbOpenWorldLog.UseSelectable = true;
            pbOpenWorldLog.Click += OpenLogXiWorldButton_Click;
            // 
            // pbOpenSearchLog
            // 
            pbOpenSearchLog.DisplayFocus = true;
            pbOpenSearchLog.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            pbOpenSearchLog.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            pbOpenSearchLog.Highlight = true;
            pbOpenSearchLog.ImeMode = ImeMode.NoControl;
            pbOpenSearchLog.Location = new Point(203, 127);
            pbOpenSearchLog.Margin = new Padding(2, 3, 2, 3);
            pbOpenSearchLog.Name = "pbOpenSearchLog";
            pbOpenSearchLog.Size = new Size(192, 49);
            pbOpenSearchLog.TabIndex = 25;
            pbOpenSearchLog.Text = "Xi Search Console";
            pbOpenSearchLog.UseSelectable = true;
            pbOpenSearchLog.Click += OpenLogXiSearchButton_Click;
            // 
            // pbOpenConnectLog
            // 
            pbOpenConnectLog.DisplayFocus = true;
            pbOpenConnectLog.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            pbOpenConnectLog.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            pbOpenConnectLog.Highlight = true;
            pbOpenConnectLog.ImeMode = ImeMode.NoControl;
            pbOpenConnectLog.Location = new Point(6, 127);
            pbOpenConnectLog.Name = "pbOpenConnectLog";
            pbOpenConnectLog.Size = new Size(192, 49);
            pbOpenConnectLog.TabIndex = 24;
            pbOpenConnectLog.Text = "Xi Connect Console";
            pbOpenConnectLog.UseSelectable = true;
            pbOpenConnectLog.Click += OpenLogXiConnectButton_Click;
            // 
            // pbOpenGameLog
            // 
            pbOpenGameLog.DisplayFocus = true;
            pbOpenGameLog.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            pbOpenGameLog.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            pbOpenGameLog.Highlight = true;
            pbOpenGameLog.ImeMode = ImeMode.NoControl;
            pbOpenGameLog.Location = new Point(6, 207);
            pbOpenGameLog.Name = "pbOpenGameLog";
            pbOpenGameLog.Size = new Size(192, 49);
            pbOpenGameLog.TabIndex = 23;
            pbOpenGameLog.Text = "Xi Launcher Console";
            pbOpenGameLog.UseSelectable = true;
            // 
            // pbOpenDatabaseLog
            // 
            pbOpenDatabaseLog.DisplayFocus = true;
            pbOpenDatabaseLog.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            pbOpenDatabaseLog.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            pbOpenDatabaseLog.Highlight = true;
            pbOpenDatabaseLog.Location = new Point(6, 32);
            pbOpenDatabaseLog.Name = "pbOpenDatabaseLog";
            pbOpenDatabaseLog.Size = new Size(192, 49);
            pbOpenDatabaseLog.TabIndex = 22;
            pbOpenDatabaseLog.Text = "Database Console";
            pbOpenDatabaseLog.UseSelectable = true;
            pbOpenDatabaseLog.Click += OpenLogDatabaseButton_Click;
            // 
            // panelTabLogs
            // 
            panelTabLogs.Dock = DockStyle.Fill;
            panelTabLogs.HorizontalScrollbarBarColor = true;
            panelTabLogs.HorizontalScrollbarHighlightOnWheel = false;
            panelTabLogs.HorizontalScrollbarSize = 10;
            panelTabLogs.Location = new Point(3, 3);
            panelTabLogs.Name = "panelTabLogs";
            panelTabLogs.Size = new Size(788, 340);
            panelTabLogs.TabIndex = 31;
            panelTabLogs.VerticalScrollbarBarColor = true;
            panelTabLogs.VerticalScrollbarHighlightOnWheel = false;
            panelTabLogs.VerticalScrollbarSize = 10;
            // 
            // flowPanelStatusBar
            // 
            flowPanelStatusBar.AutoSize = true;
            flowPanelStatusBar.Controls.Add(poisonLabel2);
            flowPanelStatusBar.Controls.Add(poisonLabel1);
            flowPanelStatusBar.Dock = DockStyle.Bottom;
            flowPanelStatusBar.Location = new Point(8, 451);
            flowPanelStatusBar.Name = "flowPanelStatusBar";
            flowPanelStatusBar.Size = new Size(802, 25);
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
            panelStatus.Size = new Size(231, 24);
            panelStatus.TabIndex = 33;
            panelStatus.VerticalScrollbarBarColor = true;
            panelStatus.VerticalScrollbarHighlightOnWheel = false;
            panelStatus.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pbStatusGame);
            flowLayoutPanel1.Controls.Add(pbStatusMap);
            flowLayoutPanel1.Controls.Add(pbStatusWorld);
            flowLayoutPanel1.Controls.Add(pbStatusSearch);
            flowLayoutPanel1.Controls.Add(pbStatusConnect);
            flowLayoutPanel1.Controls.Add(pbStatusDatabase);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(231, 24);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // pbStatusGame
            // 
            pbStatusGame.BackColor = Color.IndianRed;
            pbStatusGame.BorderStyle = BorderStyle.FixedSingle;
            pbStatusGame.Image = Properties.Resources.videogame_asset_48dp_F1F1F1;
            pbStatusGame.Location = new Point(207, 0);
            pbStatusGame.Margin = new Padding(12, 0, 0, 0);
            pbStatusGame.Name = "pbStatusGame";
            pbStatusGame.Size = new Size(24, 24);
            pbStatusGame.SizeMode = PictureBoxSizeMode.Zoom;
            pbStatusGame.TabIndex = 12;
            pbStatusGame.TabStop = false;
            // 
            // pbStatusMap
            // 
            pbStatusMap.BackColor = Color.IndianRed;
            pbStatusMap.BorderStyle = BorderStyle.FixedSingle;
            pbStatusMap.Image = Properties.Resources.map_48dp_F1F1F1;
            pbStatusMap.Location = new Point(171, 0);
            pbStatusMap.Margin = new Padding(12, 0, 0, 0);
            pbStatusMap.Name = "pbStatusMap";
            pbStatusMap.Size = new Size(24, 24);
            pbStatusMap.SizeMode = PictureBoxSizeMode.Zoom;
            pbStatusMap.TabIndex = 13;
            pbStatusMap.TabStop = false;
            // 
            // pbStatusWorld
            // 
            pbStatusWorld.BackColor = Color.IndianRed;
            pbStatusWorld.BorderStyle = BorderStyle.FixedSingle;
            pbStatusWorld.Image = Properties.Resources.globe_48dp_F1F1F1;
            pbStatusWorld.Location = new Point(135, 0);
            pbStatusWorld.Margin = new Padding(12, 0, 0, 0);
            pbStatusWorld.Name = "pbStatusWorld";
            pbStatusWorld.Size = new Size(24, 24);
            pbStatusWorld.SizeMode = PictureBoxSizeMode.Zoom;
            pbStatusWorld.TabIndex = 14;
            pbStatusWorld.TabStop = false;
            // 
            // pbStatusSearch
            // 
            pbStatusSearch.BackColor = Color.IndianRed;
            pbStatusSearch.BorderStyle = BorderStyle.FixedSingle;
            pbStatusSearch.Image = Properties.Resources.database_search_48dp_F1F1F1;
            pbStatusSearch.Location = new Point(99, 0);
            pbStatusSearch.Margin = new Padding(12, 0, 0, 0);
            pbStatusSearch.Name = "pbStatusSearch";
            pbStatusSearch.Size = new Size(24, 24);
            pbStatusSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pbStatusSearch.TabIndex = 15;
            pbStatusSearch.TabStop = false;
            // 
            // pbStatusConnect
            // 
            pbStatusConnect.BackColor = Color.IndianRed;
            pbStatusConnect.BorderStyle = BorderStyle.FixedSingle;
            pbStatusConnect.Image = Properties.Resources.router_48dp_F1F1F1;
            pbStatusConnect.Location = new Point(63, 0);
            pbStatusConnect.Margin = new Padding(12, 0, 0, 0);
            pbStatusConnect.Name = "pbStatusConnect";
            pbStatusConnect.Size = new Size(24, 24);
            pbStatusConnect.SizeMode = PictureBoxSizeMode.Zoom;
            pbStatusConnect.TabIndex = 16;
            pbStatusConnect.TabStop = false;
            // 
            // pbStatusDatabase
            // 
            pbStatusDatabase.BackColor = Color.IndianRed;
            pbStatusDatabase.BorderStyle = BorderStyle.FixedSingle;
            pbStatusDatabase.Image = Properties.Resources.data_table_48dp_F1F1F1;
            pbStatusDatabase.Location = new Point(27, 0);
            pbStatusDatabase.Margin = new Padding(12, 0, 0, 0);
            pbStatusDatabase.Name = "pbStatusDatabase";
            pbStatusDatabase.Size = new Size(24, 24);
            pbStatusDatabase.SizeMode = PictureBoxSizeMode.Zoom;
            pbStatusDatabase.TabIndex = 17;
            pbStatusDatabase.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(818, 479);
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
            Text = "XiLauncher - FFXI Server Environment";
            poisonTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panelTabGame.ResumeLayout(false);
            poisonPanel2.ResumeLayout(false);
            poisonPanel2.PerformLayout();
            poisonPanel3.ResumeLayout(false);
            poisonPanel3.PerformLayout();
            poisonPanel1.ResumeLayout(false);
            poisonPanel1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            flowPanelStatusBar.ResumeLayout(false);
            flowPanelStatusBar.PerformLayout();
            panelStatus.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbStatusGame).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStatusMap).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStatusWorld).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStatusSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStatusConnect).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStatusDatabase).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imageListTabs;
        private Button bQuit;
        private ReaLTaiizor.Controls.PoisonTabControl poisonTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage3;
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
        private ReaLTaiizor.Controls.PoisonPanel poisonPanel3;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel8;
        private ReaLTaiizor.Controls.PoisonButton pbStartGame;
        private ReaLTaiizor.Controls.PoisonPanel panelTabGame;
        private ReaLTaiizor.Controls.PoisonButton pbQuitLauncher;
        private Controls.XiUserConfigControl userConfigControl;
        private ReaLTaiizor.Controls.PoisonPanel panelTabLogs;
        private ReaLTaiizor.Controls.PoisonPanel panelStatus;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pbStatusGame;
        private PictureBox pbStatusMap;
        private PictureBox pbStatusWorld;
        private PictureBox pbStatusSearch;
        private PictureBox pbStatusConnect;
        private PictureBox pbStatusDatabase;
    }
}
