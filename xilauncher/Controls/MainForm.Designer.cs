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
            imageListTabs = new ImageList(components);
            tabMonitor = new TabPage();
            statusStrip.SuspendLayout();
            tabLauncher.SuspendLayout();
            tabLaunch.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tabConfig.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { tsslBaseDirLabel, tsslBaseDir });
            statusStrip.Location = new Point(0, 273);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(615, 32);
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
            tabLauncher.HotTrack = true;
            tabLauncher.ImageList = imageListTabs;
            tabLauncher.ItemSize = new Size(39, 35);
            tabLauncher.Location = new Point(0, 0);
            tabLauncher.Multiline = true;
            tabLauncher.Name = "tabLauncher";
            tabLauncher.SelectedIndex = 0;
            tabLauncher.Size = new Size(616, 273);
            tabLauncher.SizeMode = TabSizeMode.Fixed;
            tabLauncher.TabIndex = 3;
            // 
            // tabLaunch
            // 
            tabLaunch.Controls.Add(flowLayoutPanel1);
            tabLaunch.ImageKey = "blue_x32.png";
            tabLaunch.Location = new Point(39, 4);
            tabLaunch.Name = "tabLaunch";
            tabLaunch.Padding = new Padding(3);
            tabLaunch.Size = new Size(573, 265);
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
            flowLayoutPanel1.Size = new Size(567, 259);
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
            xiUserConfigControl.Location = new Point(17, 3);
            xiUserConfigControl.Name = "xiUserConfigControl";
            xiUserConfigControl.ShowButtons = false;
            xiUserConfigControl.Size = new Size(364, 181);
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
            buttonLaunchGame.Location = new Point(18, 190);
            buttonLaunchGame.Name = "buttonLaunchGame";
            buttonLaunchGame.Size = new Size(362, 64);
            buttonLaunchGame.TabIndex = 10;
            buttonLaunchGame.Text = "Launch Game";
            buttonLaunchGame.UseVisualStyleBackColor = true;
            buttonLaunchGame.Click += ButtonLaunchGame_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Location = new Point(390, 3);
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
            buttonLaunchDatabase.Location = new Point(401, 3);
            buttonLaunchDatabase.Name = "buttonLaunchDatabase";
            buttonLaunchDatabase.Size = new Size(160, 64);
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
            buttonLaunchEnvironment.Location = new Point(401, 82);
            buttonLaunchEnvironment.Margin = new Padding(3, 12, 3, 12);
            buttonLaunchEnvironment.Name = "buttonLaunchEnvironment";
            buttonLaunchEnvironment.Size = new Size(160, 64);
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
            buttonQuitLauncher.Location = new Point(401, 190);
            buttonQuitLauncher.Margin = new Padding(3, 32, 3, 3);
            buttonQuitLauncher.Name = "buttonQuitLauncher";
            buttonQuitLauncher.Size = new Size(160, 64);
            buttonQuitLauncher.TabIndex = 11;
            buttonQuitLauncher.Text = "Quit";
            buttonQuitLauncher.UseVisualStyleBackColor = false;
            buttonQuitLauncher.Click += ButtonQuitLauncher_Click;
            // 
            // tabConfig
            // 
            tabConfig.Controls.Add(flowLayoutPanel2);
            tabConfig.ImageKey = "blue_x32.png";
            tabConfig.Location = new Point(39, 4);
            tabConfig.Name = "tabConfig";
            tabConfig.Padding = new Padding(3);
            tabConfig.Size = new Size(573, 265);
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
            flowLayoutPanel2.Size = new Size(567, 259);
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
            xiPolConfigControl2.Size = new Size(214, 222);
            xiPolConfigControl2.TabIndex = 25;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DimGray;
            panel4.Location = new Point(240, 3);
            panel4.Margin = new Padding(6, 3, 6, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(2, 251);
            panel4.TabIndex = 27;
            // 
            // imageListTabs
            // 
            imageListTabs.ColorDepth = ColorDepth.Depth32Bit;
            imageListTabs.ImageStream = (ImageListStreamer)resources.GetObject("imageListTabs.ImageStream");
            imageListTabs.TransparentColor = Color.Transparent;
            imageListTabs.Images.SetKeyName(0, "blue_x32.png");
            // 
            // tabMonitor
            // 
            tabMonitor.Location = new Point(4, 34);
            tabMonitor.Name = "tabMonitor";
            tabMonitor.Padding = new Padding(3);
            tabMonitor.Size = new Size(985, 444);
            tabMonitor.TabIndex = 1;
            tabMonitor.Text = "Monitor";
            tabMonitor.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 305);
            ControlBox = false;
            Controls.Add(tabLauncher);
            Controls.Add(statusStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "xilauncher - FFXI Personal Server Environment Launcher";
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip;
        private TabControl tabLauncher;
        private TabPage tabLaunch;
        private TabPage tabMonitor;
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
        private Panel panel4;
        private Controls.XiExternalConfigControl xiPolConfigControl2;
        private ImageList imageListTabs;
        private Panel panel2;
        private Panel panel3;
    }
}
