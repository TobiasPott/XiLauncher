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
            button1 = new Button();
            poisonTabControl1 = new ReaLTaiizor.Controls.PoisonTabControl();
            tabPage1 = new TabPage();
            poisonPanel4 = new ReaLTaiizor.Controls.PoisonPanel();
            poisonButton13 = new ReaLTaiizor.Controls.PoisonButton();
            poisonPanel2 = new ReaLTaiizor.Controls.PoisonPanel();
            poisonButton7 = new ReaLTaiizor.Controls.PoisonButton();
            poisonButton8 = new ReaLTaiizor.Controls.PoisonButton();
            poisonLabel7 = new ReaLTaiizor.Controls.PoisonLabel();
            poisonButton9 = new ReaLTaiizor.Controls.PoisonButton();
            poisonPanel3 = new ReaLTaiizor.Controls.PoisonPanel();
            userConfigControl = new xilauncher.Controls.XiUserConfigControl();
            poisonButton12 = new ReaLTaiizor.Controls.PoisonButton();
            poisonLabel8 = new ReaLTaiizor.Controls.PoisonLabel();
            poisonPanel1 = new ReaLTaiizor.Controls.PoisonPanel();
            poisonButton11 = new ReaLTaiizor.Controls.PoisonButton();
            poisonButton10 = new ReaLTaiizor.Controls.PoisonButton();
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
            flowPanelStatusBar = new FlowLayoutPanel();
            poisonLabel2 = new ReaLTaiizor.Controls.PoisonLabel();
            poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            poisonTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            poisonPanel4.SuspendLayout();
            poisonPanel2.SuspendLayout();
            poisonPanel3.SuspendLayout();
            poisonPanel1.SuspendLayout();
            tabPage3.SuspendLayout();
            flowPanelStatusBar.SuspendLayout();
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
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.IndianRed;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.HighlightText;
            button1.ImageKey = "logout_48dp_1F1F1F.png";
            button1.ImageList = imageListTabs;
            button1.Location = new Point(720, 12);
            button1.Margin = new Padding(2, 27, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(64, 64);
            button1.TabIndex = 28;
            button1.UseVisualStyleBackColor = false;
            button1.Click += ButtonQuitLauncher_Click;
            // 
            // poisonTabControl1
            // 
            poisonTabControl1.Controls.Add(tabPage1);
            poisonTabControl1.Controls.Add(tabPage2);
            poisonTabControl1.Controls.Add(tabPage3);
            poisonTabControl1.Dock = DockStyle.Top;
            poisonTabControl1.FontSize = ReaLTaiizor.Extension.Poison.PoisonTabControlSize.Tall;
            poisonTabControl1.FontWeight = ReaLTaiizor.Extension.Poison.PoisonTabControlWeight.Regular;
            poisonTabControl1.Location = new Point(8, 60);
            poisonTabControl1.Name = "poisonTabControl1";
            poisonTabControl1.Padding = new Point(6, 8);
            poisonTabControl1.SelectedIndex = 0;
            poisonTabControl1.Size = new Size(800, 342);
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
            tabPage1.Size = new Size(792, 294);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Game";
            // 
            // poisonPanel4
            // 
            poisonPanel4.Controls.Add(poisonButton13);
            poisonPanel4.Controls.Add(poisonPanel2);
            poisonPanel4.Controls.Add(poisonPanel3);
            poisonPanel4.Controls.Add(poisonPanel1);
            poisonPanel4.Dock = DockStyle.Fill;
            poisonPanel4.HorizontalScrollbarBarColor = true;
            poisonPanel4.HorizontalScrollbarHighlightOnWheel = false;
            poisonPanel4.HorizontalScrollbarSize = 10;
            poisonPanel4.Location = new Point(3, 3);
            poisonPanel4.Name = "poisonPanel4";
            poisonPanel4.Size = new Size(786, 288);
            poisonPanel4.TabIndex = 49;
            poisonPanel4.VerticalScrollbarBarColor = true;
            poisonPanel4.VerticalScrollbarHighlightOnWheel = false;
            poisonPanel4.VerticalScrollbarSize = 10;
            // 
            // poisonButton13
            // 
            poisonButton13.BackColor = Color.IndianRed;
            poisonButton13.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            poisonButton13.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            poisonButton13.ForeColor = SystemColors.HighlightText;
            poisonButton13.Highlight = true;
            poisonButton13.ImeMode = ImeMode.NoControl;
            poisonButton13.Location = new Point(397, 237);
            poisonButton13.Name = "poisonButton13";
            poisonButton13.Size = new Size(388, 49);
            poisonButton13.TabIndex = 46;
            poisonButton13.Text = "Quit";
            poisonButton13.UseCustomBackColor = true;
            poisonButton13.UseCustomForeColor = true;
            poisonButton13.UseSelectable = true;
            poisonButton13.UseVisualStyleBackColor = false;
            poisonButton13.Click += ButtonQuitLauncher_Click;
            // 
            // poisonPanel2
            // 
            poisonPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            poisonPanel2.Controls.Add(poisonButton7);
            poisonPanel2.Controls.Add(poisonButton8);
            poisonPanel2.Controls.Add(poisonLabel7);
            poisonPanel2.Controls.Add(poisonButton9);
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
            // poisonButton7
            // 
            poisonButton7.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            poisonButton7.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            poisonButton7.Highlight = true;
            poisonButton7.ImeMode = ImeMode.NoControl;
            poisonButton7.Location = new Point(195, 28);
            poisonButton7.Name = "poisonButton7";
            poisonButton7.Size = new Size(193, 49);
            poisonButton7.TabIndex = 43;
            poisonButton7.Text = "Gamepad";
            poisonButton7.UseSelectable = true;
            poisonButton7.Click += OpenGamepadConfigButton_Click;
            // 
            // poisonButton8
            // 
            poisonButton8.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            poisonButton8.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            poisonButton8.Highlight = true;
            poisonButton8.ImeMode = ImeMode.NoControl;
            poisonButton8.Location = new Point(0, 83);
            poisonButton8.Name = "poisonButton8";
            poisonButton8.Size = new Size(193, 49);
            poisonButton8.TabIndex = 44;
            poisonButton8.Text = "PlayOnline";
            poisonButton8.UseSelectable = true;
            poisonButton8.Click += OpenPlayOnlineConfigButton_Click;
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
            // poisonButton9
            // 
            poisonButton9.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            poisonButton9.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            poisonButton9.Highlight = true;
            poisonButton9.ImeMode = ImeMode.NoControl;
            poisonButton9.Location = new Point(0, 28);
            poisonButton9.Name = "poisonButton9";
            poisonButton9.Size = new Size(193, 49);
            poisonButton9.TabIndex = 42;
            poisonButton9.Text = "Game";
            poisonButton9.UseSelectable = true;
            poisonButton9.Click += OpenGameConfigButton_Click;
            // 
            // poisonPanel3
            // 
            poisonPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            poisonPanel3.Controls.Add(userConfigControl);
            poisonPanel3.Controls.Add(poisonButton12);
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
            // poisonButton12
            // 
            poisonButton12.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            poisonButton12.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            poisonButton12.Highlight = true;
            poisonButton12.ImeMode = ImeMode.NoControl;
            poisonButton12.Location = new Point(2, 234);
            poisonButton12.Name = "poisonButton12";
            poisonButton12.Size = new Size(383, 49);
            poisonButton12.TabIndex = 45;
            poisonButton12.Text = "Start Game";
            poisonButton12.UseSelectable = true;
            poisonButton12.Click += ButtonLaunchGame_Click;
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
            poisonPanel1.Controls.Add(poisonButton11);
            poisonPanel1.Controls.Add(poisonButton10);
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
            // poisonButton11
            // 
            poisonButton11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            poisonButton11.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            poisonButton11.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            poisonButton11.ImeMode = ImeMode.NoControl;
            poisonButton11.Location = new Point(192, 28);
            poisonButton11.Name = "poisonButton11";
            poisonButton11.Size = new Size(193, 49);
            poisonButton11.TabIndex = 46;
            poisonButton11.Text = "Start Server";
            poisonButton11.UseCustomBackColor = true;
            poisonButton11.UseSelectable = true;
            poisonButton11.UseVisualStyleBackColor = false;
            poisonButton11.Click += ButtonLaunchEnvironment_Click;
            // 
            // poisonButton10
            // 
            poisonButton10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            poisonButton10.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            poisonButton10.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            poisonButton10.Highlight = true;
            poisonButton10.ImeMode = ImeMode.NoControl;
            poisonButton10.Location = new Point(0, 28);
            poisonButton10.Name = "poisonButton10";
            poisonButton10.Size = new Size(193, 49);
            poisonButton10.TabIndex = 45;
            poisonButton10.Text = "Start Database";
            poisonButton10.UseSelectable = true;
            poisonButton10.Click += ButtonLaunchDatabase_Click;
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
            tabPage2.Size = new Size(796, 303);
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
            tabPage3.Location = new Point(4, 35);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(796, 303);
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
            poisonButton5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            poisonButton5.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            poisonButton5.Highlight = true;
            poisonButton5.ImeMode = ImeMode.NoControl;
            poisonButton5.Location = new Point(603, 127);
            poisonButton5.Name = "poisonButton5";
            poisonButton5.Size = new Size(193, 49);
            poisonButton5.TabIndex = 27;
            poisonButton5.Text = "Xi Map Console";
            poisonButton5.UseSelectable = true;
            // 
            // poisonButton6
            // 
            poisonButton6.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            poisonButton6.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            poisonButton6.Highlight = true;
            poisonButton6.ImeMode = ImeMode.NoControl;
            poisonButton6.Location = new Point(404, 127);
            poisonButton6.Name = "poisonButton6";
            poisonButton6.Size = new Size(193, 49);
            poisonButton6.TabIndex = 26;
            poisonButton6.Text = "Xi World Console";
            poisonButton6.UseSelectable = true;
            // 
            // poisonButton3
            // 
            poisonButton3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            poisonButton3.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            poisonButton3.Highlight = true;
            poisonButton3.ImeMode = ImeMode.NoControl;
            poisonButton3.Location = new Point(205, 127);
            poisonButton3.Name = "poisonButton3";
            poisonButton3.Size = new Size(193, 49);
            poisonButton3.TabIndex = 25;
            poisonButton3.Text = "Xi Search Console";
            poisonButton3.UseSelectable = true;
            // 
            // poisonButton4
            // 
            poisonButton4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            poisonButton4.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            poisonButton4.Highlight = true;
            poisonButton4.ImeMode = ImeMode.NoControl;
            poisonButton4.Location = new Point(6, 127);
            poisonButton4.Name = "poisonButton4";
            poisonButton4.Size = new Size(193, 49);
            poisonButton4.TabIndex = 24;
            poisonButton4.Text = "Xi Connect Console";
            poisonButton4.UseSelectable = true;
            // 
            // poisonButton2
            // 
            poisonButton2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            poisonButton2.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            poisonButton2.Highlight = true;
            poisonButton2.ImeMode = ImeMode.NoControl;
            poisonButton2.Location = new Point(6, 207);
            poisonButton2.Name = "poisonButton2";
            poisonButton2.Size = new Size(193, 49);
            poisonButton2.TabIndex = 23;
            poisonButton2.Text = "Xi Launcher Console";
            poisonButton2.UseSelectable = true;
            // 
            // poisonButton1
            // 
            poisonButton1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            poisonButton1.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            poisonButton1.Highlight = true;
            poisonButton1.Location = new Point(6, 32);
            poisonButton1.Name = "poisonButton1";
            poisonButton1.Size = new Size(193, 49);
            poisonButton1.TabIndex = 22;
            poisonButton1.Text = "Database Console";
            poisonButton1.UseSelectable = true;
            poisonButton1.Click += OpenLogDatabaseButton_Click;
            // 
            // flowPanelStatusBar
            // 
            flowPanelStatusBar.AutoSize = true;
            flowPanelStatusBar.Controls.Add(poisonLabel2);
            flowPanelStatusBar.Controls.Add(poisonLabel1);
            flowPanelStatusBar.Dock = DockStyle.Bottom;
            flowPanelStatusBar.Location = new Point(8, 399);
            flowPanelStatusBar.Name = "flowPanelStatusBar";
            flowPanelStatusBar.Size = new Size(800, 25);
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
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(816, 427);
            ControlBox = false;
            Controls.Add(flowPanelStatusBar);
            Controls.Add(button1);
            Controls.Add(poisonTabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "MainForm";
            Padding = new Padding(8, 60, 8, 3);
            ShowIcon = false;
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imageListTabs;
        private Button button1;
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
        private ReaLTaiizor.Controls.PoisonButton poisonButton9;
        private ReaLTaiizor.Controls.PoisonButton poisonButton7;
        private ReaLTaiizor.Controls.PoisonButton poisonButton11;
        private ReaLTaiizor.Controls.PoisonButton poisonButton10;
        private ReaLTaiizor.Controls.PoisonButton poisonButton8;
        private ReaLTaiizor.Controls.PoisonPanel poisonPanel2;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel7;
        private ReaLTaiizor.Controls.PoisonPanel poisonPanel3;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel8;
        private ReaLTaiizor.Controls.PoisonButton poisonButton12;
        private ReaLTaiizor.Controls.PoisonPanel poisonPanel4;
        private ReaLTaiizor.Controls.PoisonButton poisonButton13;
        private Controls.XiUserConfigControl userConfigControl;
    }
}
