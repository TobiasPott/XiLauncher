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
            poisonPanel4 = new ReaLTaiizor.Controls.PoisonPanel();
            pbQuitLauncher = new ReaLTaiizor.Controls.PoisonButton();
            poisonPanel2 = new ReaLTaiizor.Controls.PoisonPanel();
            pbOpenConfigGamepad = new ReaLTaiizor.Controls.PoisonButton();
            pbOpenConfigPlayOnline = new ReaLTaiizor.Controls.PoisonButton();
            poisonLabel7 = new ReaLTaiizor.Controls.PoisonLabel();
            pbOpenConfigGame = new ReaLTaiizor.Controls.PoisonButton();
            poisonPanel3 = new ReaLTaiizor.Controls.PoisonPanel();
            userConfigControl = new xilauncher.Controls.XiUserConfigControl();
            pbStartGame = new ReaLTaiizor.Controls.PoisonButton();
            poisonLabel8 = new ReaLTaiizor.Controls.PoisonLabel();
            poisonPanel1 = new ReaLTaiizor.Controls.PoisonPanel();
            pbStartServer = new ReaLTaiizor.Controls.PoisonButton();
            pbStartDatabase = new ReaLTaiizor.Controls.PoisonButton();
            poisonLabel3 = new ReaLTaiizor.Controls.PoisonLabel();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            poisonLabel6 = new ReaLTaiizor.Controls.PoisonLabel();
            poisonLabel5 = new ReaLTaiizor.Controls.PoisonLabel();
            poisonLabel4 = new ReaLTaiizor.Controls.PoisonLabel();
            poisonButton5 = new ReaLTaiizor.Controls.PoisonButton();
            poisonButton6 = new ReaLTaiizor.Controls.PoisonButton();
            poisonButton3 = new ReaLTaiizor.Controls.PoisonButton();
            poisonButton4 = new ReaLTaiizor.Controls.PoisonButton();
            poisonButton2 = new ReaLTaiizor.Controls.PoisonButton();
            poisonButton1 = new ReaLTaiizor.Controls.PoisonButton();
            poisonPanel5 = new ReaLTaiizor.Controls.PoisonPanel();
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
            poisonPanel4.SuspendLayout();
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
            poisonTabControl1.Controls.Add(tabPage1);
            poisonTabControl1.Controls.Add(tabPage2);
            poisonTabControl1.Controls.Add(tabPage3);
            poisonTabControl1.Dock = DockStyle.Top;
            poisonTabControl1.FontSize = ReaLTaiizor.Extension.Poison.PoisonTabControlSize.Tall;
            poisonTabControl1.FontWeight = ReaLTaiizor.Extension.Poison.PoisonTabControlWeight.Regular;
            poisonTabControl1.HotTrack = true;
            poisonTabControl1.Location = new Point(8, 60);
            poisonTabControl1.Name = "poisonTabControl1";
            poisonTabControl1.Padding = new Point(6, 8);
            poisonTabControl1.SelectedIndex = 0;
            poisonTabControl1.Size = new Size(802, 342);
            poisonTabControl1.TabIndex = 29;
            poisonTabControl1.UseSelectable = true;
            poisonTabControl1.UseStyleColors = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(poisonPanel4);
            tabPage1.Location = new Point(4, 44);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(794, 294);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Game";
            // 
            // poisonPanel4
            // 
            poisonPanel4.Controls.Add(pbQuitLauncher);
            poisonPanel4.Controls.Add(poisonPanel2);
            poisonPanel4.Controls.Add(poisonPanel3);
            poisonPanel4.Controls.Add(poisonPanel1);
            poisonPanel4.Dock = DockStyle.Fill;
            poisonPanel4.HorizontalScrollbarBarColor = true;
            poisonPanel4.HorizontalScrollbarHighlightOnWheel = false;
            poisonPanel4.HorizontalScrollbarSize = 10;
            poisonPanel4.Location = new Point(3, 3);
            poisonPanel4.Name = "poisonPanel4";
            poisonPanel4.Size = new Size(788, 288);
            poisonPanel4.TabIndex = 49;
            poisonPanel4.VerticalScrollbarBarColor = true;
            poisonPanel4.VerticalScrollbarHighlightOnWheel = false;
            poisonPanel4.VerticalScrollbarSize = 10;
            // 
            // pbQuitLauncher
            // 
            pbQuitLauncher.BackColor = Color.IndianRed;
            pbQuitLauncher.DisplayFocus = true;
            pbQuitLauncher.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            pbQuitLauncher.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            pbQuitLauncher.ForeColor = SystemColors.HighlightText;
            pbQuitLauncher.ImeMode = ImeMode.NoControl;
            pbQuitLauncher.Location = new Point(397, 237);
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
            poisonPanel2.Location = new Point(397, 89);
            poisonPanel2.Name = "poisonPanel2";
            poisonPanel2.Size = new Size(388, 142);
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
            pbOpenConfigGamepad.Location = new Point(199, 28);
            pbOpenConfigGamepad.Name = "pbOpenConfigGamepad";
            pbOpenConfigGamepad.Size = new Size(189, 49);
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
            pbOpenConfigPlayOnline.Location = new Point(0, 83);
            pbOpenConfigPlayOnline.Name = "pbOpenConfigPlayOnline";
            pbOpenConfigPlayOnline.Size = new Size(193, 49);
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
            pbOpenConfigGame.Size = new Size(193, 49);
            pbOpenConfigGame.TabIndex = 42;
            pbOpenConfigGame.Text = "Game";
            pbOpenConfigGame.UseSelectable = true;
            pbOpenConfigGame.Click += OpenGameConfigButton_Click;
            // 
            // poisonPanel3
            // 
            poisonPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            poisonPanel3.Controls.Add(userConfigControl);
            poisonPanel3.Controls.Add(pbStartGame);
            poisonPanel3.Controls.Add(poisonLabel8);
            poisonPanel3.HorizontalScrollbarBarColor = true;
            poisonPanel3.HorizontalScrollbarHighlightOnWheel = false;
            poisonPanel3.HorizontalScrollbarSize = 10;
            poisonPanel3.Location = new Point(3, 3);
            poisonPanel3.Name = "poisonPanel3";
            poisonPanel3.Size = new Size(388, 292);
            poisonPanel3.TabIndex = 48;
            poisonPanel3.VerticalScrollbarBarColor = true;
            poisonPanel3.VerticalScrollbarHighlightOnWheel = false;
            poisonPanel3.VerticalScrollbarSize = 10;
            // 
            // userConfigControl
            // 
            userConfigControl.AutoSize = true;
            userConfigControl.Location = new Point(0, 28);
            userConfigControl.Name = "userConfigControl";
            userConfigControl.Size = new Size(385, 200);
            userConfigControl.TabIndex = 46;
            // 
            // pbStartGame
            // 
            pbStartGame.DisplayFocus = true;
            pbStartGame.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            pbStartGame.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            pbStartGame.ImeMode = ImeMode.NoControl;
            pbStartGame.Location = new Point(2, 234);
            pbStartGame.Name = "pbStartGame";
            pbStartGame.Size = new Size(383, 49);
            pbStartGame.TabIndex = 45;
            pbStartGame.Text = "Start Game";
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
            // poisonPanel1
            // 
            poisonPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            poisonPanel1.Controls.Add(pbStartServer);
            poisonPanel1.Controls.Add(pbStartDatabase);
            poisonPanel1.Controls.Add(poisonLabel3);
            poisonPanel1.HorizontalScrollbarBarColor = true;
            poisonPanel1.HorizontalScrollbarHighlightOnWheel = false;
            poisonPanel1.HorizontalScrollbarSize = 10;
            poisonPanel1.Location = new Point(397, 3);
            poisonPanel1.Name = "poisonPanel1";
            poisonPanel1.Size = new Size(388, 80);
            poisonPanel1.TabIndex = 39;
            poisonPanel1.VerticalScrollbarBarColor = true;
            poisonPanel1.VerticalScrollbarHighlightOnWheel = false;
            poisonPanel1.VerticalScrollbarSize = 10;
            // 
            // pbStartServer
            // 
            pbStartServer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbStartServer.DisplayFocus = true;
            pbStartServer.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            pbStartServer.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            pbStartServer.ImeMode = ImeMode.NoControl;
            pbStartServer.Location = new Point(199, 28);
            pbStartServer.Name = "pbStartServer";
            pbStartServer.Size = new Size(186, 49);
            pbStartServer.TabIndex = 46;
            pbStartServer.Text = "Start Server";
            pbStartServer.UseCustomBackColor = true;
            pbStartServer.UseSelectable = true;
            pbStartServer.UseVisualStyleBackColor = false;
            pbStartServer.Click += ButtonLaunchEnvironment_Click;
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
            pbStartDatabase.Text = "Start Database";
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
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 35);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(794, 303);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "Server";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(poisonLabel6);
            tabPage3.Controls.Add(poisonLabel5);
            tabPage3.Controls.Add(poisonLabel4);
            tabPage3.Controls.Add(poisonButton5);
            tabPage3.Controls.Add(poisonButton6);
            tabPage3.Controls.Add(poisonButton3);
            tabPage3.Controls.Add(poisonButton4);
            tabPage3.Controls.Add(poisonButton2);
            tabPage3.Controls.Add(poisonButton1);
            tabPage3.Controls.Add(poisonPanel5);
            tabPage3.Location = new Point(4, 35);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(794, 303);
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
            // poisonButton5
            // 
            poisonButton5.DisplayFocus = true;
            poisonButton5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            poisonButton5.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            poisonButton5.Highlight = true;
            poisonButton5.ImeMode = ImeMode.NoControl;
            poisonButton5.Location = new Point(594, 127);
            poisonButton5.Name = "poisonButton5";
            poisonButton5.Size = new Size(192, 49);
            poisonButton5.TabIndex = 27;
            poisonButton5.Text = "Xi Map Console";
            poisonButton5.UseSelectable = true;
            poisonButton5.Click += OpenLogXiMapButton_Click;
            // 
            // poisonButton6
            // 
            poisonButton6.DisplayFocus = true;
            poisonButton6.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            poisonButton6.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            poisonButton6.Highlight = true;
            poisonButton6.ImeMode = ImeMode.NoControl;
            poisonButton6.Location = new Point(400, 127);
            poisonButton6.Margin = new Padding(2, 3, 2, 3);
            poisonButton6.Name = "poisonButton6";
            poisonButton6.Size = new Size(192, 49);
            poisonButton6.TabIndex = 26;
            poisonButton6.Text = "Xi World Console";
            poisonButton6.UseSelectable = true;
            poisonButton6.Click += OpenLogXiWorldButton_Click;
            // 
            // poisonButton3
            // 
            poisonButton3.DisplayFocus = true;
            poisonButton3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            poisonButton3.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            poisonButton3.Highlight = true;
            poisonButton3.ImeMode = ImeMode.NoControl;
            poisonButton3.Location = new Point(203, 127);
            poisonButton3.Margin = new Padding(2, 3, 2, 3);
            poisonButton3.Name = "poisonButton3";
            poisonButton3.Size = new Size(192, 49);
            poisonButton3.TabIndex = 25;
            poisonButton3.Text = "Xi Search Console";
            poisonButton3.UseSelectable = true;
            poisonButton3.Click += OpenLogXiSearchButton_Click;
            // 
            // poisonButton4
            // 
            poisonButton4.DisplayFocus = true;
            poisonButton4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            poisonButton4.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            poisonButton4.Highlight = true;
            poisonButton4.ImeMode = ImeMode.NoControl;
            poisonButton4.Location = new Point(6, 127);
            poisonButton4.Name = "poisonButton4";
            poisonButton4.Size = new Size(192, 49);
            poisonButton4.TabIndex = 24;
            poisonButton4.Text = "Xi Connect Console";
            poisonButton4.UseSelectable = true;
            poisonButton4.Click += OpenLogXiConnectButton_Click;
            // 
            // poisonButton2
            // 
            poisonButton2.DisplayFocus = true;
            poisonButton2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            poisonButton2.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            poisonButton2.Highlight = true;
            poisonButton2.ImeMode = ImeMode.NoControl;
            poisonButton2.Location = new Point(6, 207);
            poisonButton2.Name = "poisonButton2";
            poisonButton2.Size = new Size(192, 49);
            poisonButton2.TabIndex = 23;
            poisonButton2.Text = "Xi Launcher Console";
            poisonButton2.UseSelectable = true;
            // 
            // poisonButton1
            // 
            poisonButton1.DisplayFocus = true;
            poisonButton1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            poisonButton1.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            poisonButton1.Highlight = true;
            poisonButton1.Location = new Point(6, 32);
            poisonButton1.Name = "poisonButton1";
            poisonButton1.Size = new Size(192, 49);
            poisonButton1.TabIndex = 22;
            poisonButton1.Text = "Database Console";
            poisonButton1.UseSelectable = true;
            poisonButton1.Click += OpenLogDatabaseButton_Click;
            // 
            // poisonPanel5
            // 
            poisonPanel5.Dock = DockStyle.Fill;
            poisonPanel5.HorizontalScrollbarBarColor = true;
            poisonPanel5.HorizontalScrollbarHighlightOnWheel = false;
            poisonPanel5.HorizontalScrollbarSize = 10;
            poisonPanel5.Location = new Point(3, 3);
            poisonPanel5.Name = "poisonPanel5";
            poisonPanel5.Size = new Size(788, 297);
            poisonPanel5.TabIndex = 31;
            poisonPanel5.VerticalScrollbarBarColor = true;
            poisonPanel5.VerticalScrollbarHighlightOnWheel = false;
            poisonPanel5.VerticalScrollbarSize = 10;
            // 
            // flowPanelStatusBar
            // 
            flowPanelStatusBar.AutoSize = true;
            flowPanelStatusBar.Controls.Add(poisonLabel2);
            flowPanelStatusBar.Controls.Add(poisonLabel1);
            flowPanelStatusBar.Dock = DockStyle.Bottom;
            flowPanelStatusBar.Location = new Point(8, 410);
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
            panelStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            ClientSize = new Size(818, 438);
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
            poisonPanel4.ResumeLayout(false);
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
        private ReaLTaiizor.Controls.PoisonButton poisonButton1;
        private ReaLTaiizor.Controls.PoisonButton poisonButton2;
        private ReaLTaiizor.Controls.PoisonButton poisonButton5;
        private ReaLTaiizor.Controls.PoisonButton poisonButton6;
        private ReaLTaiizor.Controls.PoisonButton poisonButton3;
        private ReaLTaiizor.Controls.PoisonButton poisonButton4;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel6;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel5;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel4;
        private TabPage tabPage2;
        private ReaLTaiizor.Controls.PoisonPanel poisonPanel1;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel3;
        private ReaLTaiizor.Controls.PoisonButton pbOpenConfigGame;
        private ReaLTaiizor.Controls.PoisonButton pbOpenConfigGamepad;
        private ReaLTaiizor.Controls.PoisonButton pbStartServer;
        private ReaLTaiizor.Controls.PoisonButton pbStartDatabase;
        private ReaLTaiizor.Controls.PoisonButton pbOpenConfigPlayOnline;
        private ReaLTaiizor.Controls.PoisonPanel poisonPanel2;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel7;
        private ReaLTaiizor.Controls.PoisonPanel poisonPanel3;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel8;
        private ReaLTaiizor.Controls.PoisonButton pbStartGame;
        private ReaLTaiizor.Controls.PoisonPanel poisonPanel4;
        private ReaLTaiizor.Controls.PoisonButton pbQuitLauncher;
        private Controls.XiUserConfigControl userConfigControl;
        private ReaLTaiizor.Controls.PoisonPanel poisonPanel5;
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
