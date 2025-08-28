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
            statusStrip = new StatusStrip();
            tsslBaseDirLabel = new ToolStripStatusLabel();
            tsslBaseDir = new ToolStripStatusLabel();
            tabLauncher = new TabControl();
            tabLaunch = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            xiUserConfigControl = new xilauncher.Controls.XiUserConfigControl();
            buttonLaunchGame = new Button();
            panel1 = new Panel();
            buttonLaunchDatabase = new Button();
            buttonLaunchEnvironment = new Button();
            buttonQuitLauncher = new Button();
            tabConfig = new TabPage();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel3 = new Panel();
            xiPolConfigControl2 = new xilauncher.Controls.XiExternalConfigControl();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            tabMonitor = new TabPage();
            label1 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            imageListTabs = new ImageList(components);
            button1 = new Button();
            statusStrip.SuspendLayout();
            tabLauncher.SuspendLayout();
            tabLaunch.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tabConfig.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            tabMonitor.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { tsslBaseDirLabel, tsslBaseDir });
            statusStrip.Location = new Point(0, 273);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(626, 32);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip1";
            // 
            // tsslBaseDirLabel
            // 
            tsslBaseDirLabel.Name = "tsslBaseDirLabel";
            tsslBaseDirLabel.Size = new Size(54, 25);
            tsslBaseDirLabel.Text = "Root:";
            // 
            // tsslBaseDir
            // 
            tsslBaseDir.Name = "tsslBaseDir";
            tsslBaseDir.Size = new Size(146, 25);
            tsslBaseDir.Text = "tsslBaseDirectory";
            // 
            // tabLauncher
            // 
            tabLauncher.Alignment = TabAlignment.Left;
            tabLauncher.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabLauncher.Controls.Add(tabLaunch);
            tabLauncher.Controls.Add(tabConfig);
            tabLauncher.Controls.Add(tabMonitor);
            tabLauncher.HotTrack = true;
            tabLauncher.ImageList = imageListTabs;
            tabLauncher.ItemSize = new Size(48, 48);
            tabLauncher.Location = new Point(0, 0);
            tabLauncher.Multiline = true;
            tabLauncher.Name = "tabLauncher";
            tabLauncher.Padding = new Point(0, 3);
            tabLauncher.SelectedIndex = 0;
            tabLauncher.Size = new Size(627, 273);
            tabLauncher.SizeMode = TabSizeMode.Fixed;
            tabLauncher.TabIndex = 3;
            // 
            // tabLaunch
            // 
            tabLaunch.Controls.Add(flowLayoutPanel1);
            tabLaunch.ImageKey = "sports_esports_48dp_1F1F1F.png";
            tabLaunch.Location = new Point(52, 4);
            tabLaunch.Name = "tabLaunch";
            tabLaunch.Padding = new Padding(3);
            tabLaunch.Size = new Size(571, 265);
            tabLaunch.TabIndex = 0;
            tabLaunch.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(xiUserConfigControl);
            flowLayoutPanel1.Controls.Add(buttonLaunchGame);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(buttonLaunchDatabase);
            flowLayoutPanel1.Controls.Add(buttonLaunchEnvironment);
            flowLayoutPanel1.Controls.Add(buttonQuitLauncher);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(565, 259);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Location = new Point(6, 3);
            panel2.Margin = new Padding(6, 3, 6, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(2, 251);
            panel2.TabIndex = 27;
            // 
            // xiUserConfigControl
            // 
            xiUserConfigControl.Anchor = AnchorStyles.Top;
            xiUserConfigControl.AutoSize = true;
            xiUserConfigControl.Location = new Point(18, 3);
            xiUserConfigControl.Name = "xiUserConfigControl";
            xiUserConfigControl.ShowButtons = false;
            xiUserConfigControl.Size = new Size(259, 181);
            xiUserConfigControl.TabIndex = 24;
            // 
            // buttonLaunchGame
            // 
            buttonLaunchGame.Anchor = AnchorStyles.Top;
            buttonLaunchGame.Cursor = Cursors.Hand;
            buttonLaunchGame.FlatAppearance.BorderSize = 2;
            buttonLaunchGame.FlatStyle = FlatStyle.Flat;
            buttonLaunchGame.Image = Properties.Resources.clear_x32;
            buttonLaunchGame.ImageAlign = ContentAlignment.MiddleRight;
            buttonLaunchGame.Location = new Point(17, 190);
            buttonLaunchGame.Name = "buttonLaunchGame";
            buttonLaunchGame.Size = new Size(261, 64);
            buttonLaunchGame.TabIndex = 10;
            buttonLaunchGame.Text = "Launch Game";
            buttonLaunchGame.UseVisualStyleBackColor = true;
            buttonLaunchGame.Click += ButtonLaunchGame_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Location = new Point(287, 3);
            panel1.Margin = new Padding(6, 3, 6, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 251);
            panel1.TabIndex = 26;
            // 
            // buttonLaunchDatabase
            // 
            buttonLaunchDatabase.Cursor = Cursors.Hand;
            buttonLaunchDatabase.FlatAppearance.BorderSize = 2;
            buttonLaunchDatabase.FlatStyle = FlatStyle.Flat;
            buttonLaunchDatabase.Image = Properties.Resources.clear_x32;
            buttonLaunchDatabase.ImageAlign = ContentAlignment.MiddleRight;
            buttonLaunchDatabase.Location = new Point(298, 3);
            buttonLaunchDatabase.Name = "buttonLaunchDatabase";
            buttonLaunchDatabase.Size = new Size(258, 64);
            buttonLaunchDatabase.TabIndex = 12;
            buttonLaunchDatabase.Text = "Launch Database";
            buttonLaunchDatabase.UseVisualStyleBackColor = true;
            buttonLaunchDatabase.Click += ButtonLaunchDatabase_Click;
            // 
            // buttonLaunchEnvironment
            // 
            buttonLaunchEnvironment.Cursor = Cursors.Hand;
            buttonLaunchEnvironment.FlatAppearance.BorderSize = 2;
            buttonLaunchEnvironment.FlatStyle = FlatStyle.Flat;
            buttonLaunchEnvironment.Image = Properties.Resources.clear_x32;
            buttonLaunchEnvironment.ImageAlign = ContentAlignment.MiddleRight;
            buttonLaunchEnvironment.Location = new Point(298, 82);
            buttonLaunchEnvironment.Margin = new Padding(3, 12, 3, 12);
            buttonLaunchEnvironment.Name = "buttonLaunchEnvironment";
            buttonLaunchEnvironment.Size = new Size(258, 64);
            buttonLaunchEnvironment.TabIndex = 9;
            buttonLaunchEnvironment.Text = "Launch Environment";
            buttonLaunchEnvironment.UseVisualStyleBackColor = true;
            buttonLaunchEnvironment.Click += ButtonLaunchEnvironment_Click;
            // 
            // buttonQuitLauncher
            // 
            buttonQuitLauncher.BackColor = Color.IndianRed;
            buttonQuitLauncher.Cursor = Cursors.Hand;
            buttonQuitLauncher.FlatAppearance.BorderSize = 2;
            buttonQuitLauncher.FlatStyle = FlatStyle.Flat;
            buttonQuitLauncher.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonQuitLauncher.ForeColor = SystemColors.HighlightText;
            buttonQuitLauncher.Location = new Point(298, 190);
            buttonQuitLauncher.Margin = new Padding(3, 32, 3, 3);
            buttonQuitLauncher.Name = "buttonQuitLauncher";
            buttonQuitLauncher.Size = new Size(258, 64);
            buttonQuitLauncher.TabIndex = 11;
            buttonQuitLauncher.Text = "Quit";
            buttonQuitLauncher.UseVisualStyleBackColor = false;
            buttonQuitLauncher.Click += ButtonQuitLauncher_Click;
            // 
            // tabConfig
            // 
            tabConfig.Controls.Add(flowLayoutPanel2);
            tabConfig.ImageKey = "settings_48dp_1F1F1F.png";
            tabConfig.Location = new Point(52, 4);
            tabConfig.Name = "tabConfig";
            tabConfig.Padding = new Padding(3);
            tabConfig.Size = new Size(571, 265);
            tabConfig.TabIndex = 1;
            tabConfig.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(panel3);
            flowLayoutPanel2.Controls.Add(xiPolConfigControl2);
            flowLayoutPanel2.Controls.Add(panel4);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(565, 259);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DimGray;
            panel3.Location = new Point(6, 3);
            panel3.Margin = new Padding(6, 3, 6, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(2, 251);
            panel3.TabIndex = 28;
            // 
            // xiPolConfigControl2
            // 
            xiPolConfigControl2.AutoSize = true;
            xiPolConfigControl2.Location = new Point(17, 3);
            xiPolConfigControl2.Name = "xiPolConfigControl2";
            xiPolConfigControl2.Size = new Size(246, 222);
            xiPolConfigControl2.TabIndex = 30;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DimGray;
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(272, 3);
            panel4.Margin = new Padding(6, 3, 6, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(2, 251);
            panel4.TabIndex = 32;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DimGray;
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(6, 3, 6, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(2, 251);
            panel5.TabIndex = 30;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DimGray;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(6, 3, 6, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 251);
            panel6.TabIndex = 30;
            // 
            // tabMonitor
            // 
            tabMonitor.Controls.Add(label1);
            tabMonitor.Controls.Add(flowLayoutPanel3);
            tabMonitor.ImageKey = "monitor_heart_48dp_1F1F1F.png";
            tabMonitor.Location = new Point(52, 4);
            tabMonitor.Name = "tabMonitor";
            tabMonitor.Padding = new Padding(3);
            tabMonitor.Size = new Size(571, 265);
            tabMonitor.TabIndex = 2;
            tabMonitor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 1;
            label1.Text = "Logs";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(button2);
            flowLayoutPanel3.Controls.Add(button7);
            flowLayoutPanel3.Controls.Add(button3);
            flowLayoutPanel3.Controls.Add(button4);
            flowLayoutPanel3.Controls.Add(button5);
            flowLayoutPanel3.Controls.Add(button6);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(3, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(565, 259);
            flowLayoutPanel3.TabIndex = 16;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.clear_x32;
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(3, 111);
            button3.Name = "button3";
            button3.Size = new Size(256, 48);
            button3.TabIndex = 11;
            button3.Text = "Search Server";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.clear_x32;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(256, 48);
            button2.TabIndex = 10;
            button2.Text = "Database";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.clear_x32;
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(3, 165);
            button4.Name = "button4";
            button4.Size = new Size(256, 48);
            button4.TabIndex = 12;
            button4.Text = "World Server";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 2;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = Properties.Resources.clear_x32;
            button5.ImageAlign = ContentAlignment.MiddleRight;
            button5.Location = new Point(265, 3);
            button5.Name = "button5";
            button5.Size = new Size(256, 48);
            button5.TabIndex = 13;
            button5.Text = "Map Server";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 2;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = Properties.Resources.clear_x32;
            button6.ImageAlign = ContentAlignment.MiddleRight;
            button6.Location = new Point(265, 57);
            button6.Name = "button6";
            button6.Size = new Size(256, 48);
            button6.TabIndex = 14;
            button6.Text = "Connect Server";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderSize = 2;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Image = Properties.Resources.clear_x32;
            button7.ImageAlign = ContentAlignment.MiddleRight;
            button7.Location = new Point(3, 57);
            button7.Name = "button7";
            button7.Size = new Size(256, 48);
            button7.TabIndex = 15;
            button7.Text = "Game";
            button7.UseVisualStyleBackColor = true;
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
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.IndianRed;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.HighlightText;
            button1.ImageKey = "logout_48dp_1F1F1F.png";
            button1.ImageList = imageListTabs;
            button1.Location = new Point(2, 225);
            button1.Margin = new Padding(3, 32, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(48, 48);
            button1.TabIndex = 28;
            button1.UseVisualStyleBackColor = false;
            button1.Click += ButtonQuitLauncher_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 305);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(tabLauncher);
            Controls.Add(statusStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XiLauncher - FFXI Server Environment";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            tabLauncher.ResumeLayout(false);
            tabLaunch.ResumeLayout(false);
            tabLaunch.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tabConfig.ResumeLayout(false);
            tabConfig.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tabMonitor.ResumeLayout(false);
            tabMonitor.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip;
        private TabControl tabLauncher;
        private TabPage tabLaunch;
        private ToolStripStatusLabel tsslBaseDirLabel;
        private Button buttonLaunchDatabase;
        private Button buttonQuitLauncher;
        private Button buttonLaunchGame;
        private Button buttonLaunchEnvironment;

        private FlowLayoutPanel flowLayoutPanel1;
        private Controls.XiUserConfigControl xiUserConfigControl;
        private ToolStripStatusLabel tsslBaseDir;
        private Panel panel1;
        private TabPage tabConfig;
        private FlowLayoutPanel flowLayoutPanel2;
        private ImageList imageListTabs;
        private Panel panel2;
        private Panel panel3;
        private TabPage tabMonitor;
        private Label label1;
        private Button button1;
        private Controls.XiExternalConfigControl xiPolConfigControl2;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button7;
        private FlowLayoutPanel flowLayoutPanel3;
    }
}
