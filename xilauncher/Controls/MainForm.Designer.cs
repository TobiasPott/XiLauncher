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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            statusStrip = new StatusStrip();
            tsslBaseDirLabel = new ToolStripStatusLabel();
            tsslBaseDir = new ToolStripStatusLabel();
            toolStripSplitButton1 = new ToolStripSplitButton();
            tabLauncher = new TabControl();
            tabLaunch = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonLaunchDatabase = new Button();
            buttonLaunchEnvironment = new Button();
            buttonQuitLauncher = new Button();
            xiUserConfigControl = new xilauncher.Controls.XiUserConfigControl();
            buttonLaunchGame = new Button();
            xiPolConfigControl1 = new xilauncher.Controls.XiPolConfigControl();
            tabMonitor = new TabPage();
            statusStrip.SuspendLayout();
            tabLauncher.SuspendLayout();
            tabLaunch.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { tsslBaseDirLabel, tsslBaseDir, toolStripSplitButton1 });
            statusStrip.Location = new Point(0, 305);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(765, 32);
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
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(45, 29);
            toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // tabLauncher
            // 
            tabLauncher.Controls.Add(tabLaunch);
            tabLauncher.Dock = DockStyle.Fill;
            tabLauncher.Location = new Point(0, 0);
            tabLauncher.Name = "tabLauncher";
            tabLauncher.SelectedIndex = 0;
            tabLauncher.Size = new Size(765, 305);
            tabLauncher.TabIndex = 3;
            // 
            // tabLaunch
            // 
            tabLaunch.Controls.Add(flowLayoutPanel1);
            tabLaunch.Location = new Point(4, 34);
            tabLaunch.Name = "tabLaunch";
            tabLaunch.Padding = new Padding(3);
            tabLaunch.Size = new Size(757, 267);
            tabLaunch.TabIndex = 0;
            tabLaunch.Text = "Launch";
            tabLaunch.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(xiUserConfigControl);
            flowLayoutPanel1.Controls.Add(buttonLaunchGame);
            flowLayoutPanel1.Controls.Add(buttonLaunchDatabase);
            flowLayoutPanel1.Controls.Add(buttonLaunchEnvironment);
            flowLayoutPanel1.Controls.Add(buttonQuitLauncher);
            flowLayoutPanel1.Controls.Add(xiPolConfigControl1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(751, 261);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonLaunchDatabase
            // 
            buttonLaunchDatabase.Anchor = AnchorStyles.Top;
            buttonLaunchDatabase.Cursor = Cursors.Hand;
            buttonLaunchDatabase.FlatStyle = FlatStyle.Flat;
            buttonLaunchDatabase.Image = Properties.Resources.clear_x32;
            buttonLaunchDatabase.ImageAlign = ContentAlignment.MiddleRight;
            buttonLaunchDatabase.Location = new Point(373, 3);
            buttonLaunchDatabase.Name = "buttonLaunchDatabase";
            buttonLaunchDatabase.Size = new Size(160, 64);
            buttonLaunchDatabase.TabIndex = 12;
            buttonLaunchDatabase.Text = "Launch Database";
            buttonLaunchDatabase.UseVisualStyleBackColor = true;
            buttonLaunchDatabase.Click += ButtonLaunchDatabase_Click;
            // 
            // buttonLaunchEnvironment
            // 
            buttonLaunchEnvironment.Anchor = AnchorStyles.Top;
            buttonLaunchEnvironment.Cursor = Cursors.Hand;
            buttonLaunchEnvironment.FlatStyle = FlatStyle.Flat;
            buttonLaunchEnvironment.Image = Properties.Resources.clear_x32;
            buttonLaunchEnvironment.ImageAlign = ContentAlignment.MiddleRight;
            buttonLaunchEnvironment.Location = new Point(373, 82);
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
            buttonQuitLauncher.Anchor = AnchorStyles.Top;
            buttonQuitLauncher.BackColor = Color.IndianRed;
            buttonQuitLauncher.Cursor = Cursors.Hand;
            buttonQuitLauncher.FlatStyle = FlatStyle.Flat;
            buttonQuitLauncher.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonQuitLauncher.ForeColor = SystemColors.HighlightText;
            buttonQuitLauncher.Location = new Point(373, 190);
            buttonQuitLauncher.Margin = new Padding(3, 32, 3, 3);
            buttonQuitLauncher.Name = "buttonQuitLauncher";
            buttonQuitLauncher.Size = new Size(160, 64);
            buttonQuitLauncher.TabIndex = 11;
            buttonQuitLauncher.Text = "Quit";
            buttonQuitLauncher.UseVisualStyleBackColor = false;
            buttonQuitLauncher.Click += ButtonQuitLauncher_Click;
            // 
            // xiUserConfigControl
            // 
            xiUserConfigControl.Anchor = AnchorStyles.Top;
            xiUserConfigControl.AutoSize = true;
            xiUserConfigControl.Location = new Point(3, 3);
            xiUserConfigControl.Name = "xiUserConfigControl";
            xiUserConfigControl.ShowButtons = false;
            xiUserConfigControl.Size = new Size(364, 181);
            xiUserConfigControl.TabIndex = 24;
            // 
            // buttonLaunchGame
            // 
            buttonLaunchGame.Anchor = AnchorStyles.Top;
            buttonLaunchGame.Cursor = Cursors.Hand;
            buttonLaunchGame.FlatStyle = FlatStyle.Flat;
            buttonLaunchGame.Image = Properties.Resources.clear_x32;
            buttonLaunchGame.ImageAlign = ContentAlignment.MiddleRight;
            buttonLaunchGame.Location = new Point(4, 190);
            buttonLaunchGame.Name = "buttonLaunchGame";
            buttonLaunchGame.Size = new Size(362, 64);
            buttonLaunchGame.TabIndex = 10;
            buttonLaunchGame.Text = "Launch Game";
            buttonLaunchGame.UseVisualStyleBackColor = true;
            buttonLaunchGame.Click += ButtonLaunchGame_Click;
            // 
            // xiPolConfigControl1
            // 
            xiPolConfigControl1.AutoSize = true;
            xiPolConfigControl1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            xiPolConfigControl1.Location = new Point(539, 3);
            xiPolConfigControl1.Name = "xiPolConfigControl1";
            xiPolConfigControl1.Size = new Size(214, 254);
            xiPolConfigControl1.TabIndex = 25;
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
            ClientSize = new Size(765, 337);
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
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripStatusLabel tsslBaseDir;
        private Controls.XiPolConfigControl xiPolConfigControl1;
    }
}
