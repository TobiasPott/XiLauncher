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
            statusStrip = new StatusStrip();
            tsStatusLabel = new ToolStripStatusLabel();
            tabLauncher = new TabControl();
            tabLaunch = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            xiUserConfigControl = new xilauncher.Controls.XiUserConfigControl();
            buttonLaunchGame = new Button();
            buttonLaunchEnvironment = new Button();
            buttonLaunchDatabase = new Button();
            buttonQuitLauncher = new Button();
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
            statusStrip.Items.AddRange(new ToolStripItem[] { tsStatusLabel });
            statusStrip.Location = new Point(0, 627);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(993, 32);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip1";
            // 
            // tsStatusLabel
            // 
            tsStatusLabel.Name = "tsStatusLabel";
            tsStatusLabel.Size = new Size(179, 25);
            tsStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // tabLauncher
            // 
            tabLauncher.Controls.Add(tabLaunch);
            tabLauncher.Dock = DockStyle.Fill;
            tabLauncher.Location = new Point(0, 0);
            tabLauncher.Name = "tabLauncher";
            tabLauncher.SelectedIndex = 0;
            tabLauncher.Size = new Size(993, 627);
            tabLauncher.TabIndex = 3;
            // 
            // tabLaunch
            // 
            tabLaunch.Controls.Add(flowLayoutPanel1);
            tabLaunch.Location = new Point(4, 34);
            tabLaunch.Name = "tabLaunch";
            tabLaunch.Padding = new Padding(3);
            tabLaunch.Size = new Size(985, 589);
            tabLaunch.TabIndex = 0;
            tabLaunch.Text = "Launch";
            tabLaunch.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(buttonLaunchDatabase);
            flowLayoutPanel1.Controls.Add(buttonLaunchEnvironment);
            flowLayoutPanel1.Controls.Add(xiUserConfigControl);
            flowLayoutPanel1.Controls.Add(buttonLaunchGame);
            flowLayoutPanel1.Controls.Add(buttonQuitLauncher);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(290, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(370, 579);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // xiUserConfigControl
            // 
            xiUserConfigControl.Anchor = AnchorStyles.Top;
            xiUserConfigControl.AutoSize = true;
            xiUserConfigControl.Location = new Point(3, 191);
            xiUserConfigControl.Margin = new Padding(3, 19, 3, 3);
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
            buttonLaunchGame.Location = new Point(4, 378);
            buttonLaunchGame.Name = "buttonLaunchGame";
            buttonLaunchGame.Size = new Size(362, 64);
            buttonLaunchGame.TabIndex = 10;
            buttonLaunchGame.Text = "Launch Game";
            buttonLaunchGame.UseVisualStyleBackColor = true;
            buttonLaunchGame.Click += ButtonLaunchGame_Click;
            // 
            // buttonLaunchEnvironment
            // 
            buttonLaunchEnvironment.Anchor = AnchorStyles.Top;
            buttonLaunchEnvironment.Cursor = Cursors.Hand;
            buttonLaunchEnvironment.FlatStyle = FlatStyle.Flat;
            buttonLaunchEnvironment.Image = Properties.Resources.clear_x32;
            buttonLaunchEnvironment.Location = new Point(4, 105);
            buttonLaunchEnvironment.Margin = new Padding(3, 19, 3, 3);
            buttonLaunchEnvironment.Name = "buttonLaunchEnvironment";
            buttonLaunchEnvironment.Size = new Size(362, 64);
            buttonLaunchEnvironment.TabIndex = 9;
            buttonLaunchEnvironment.Text = "Launch Environment";
            buttonLaunchEnvironment.UseVisualStyleBackColor = true;
            buttonLaunchEnvironment.Click += ButtonLaunchEnvironment_Click;
            // 
            // buttonLaunchDatabase
            // 
            buttonLaunchDatabase.Anchor = AnchorStyles.Top;
            buttonLaunchDatabase.Cursor = Cursors.Hand;
            buttonLaunchDatabase.FlatStyle = FlatStyle.Flat;
            buttonLaunchDatabase.Image = Properties.Resources.clear_x32;
            buttonLaunchDatabase.ImageAlign = ContentAlignment.MiddleRight;
            buttonLaunchDatabase.Location = new Point(4, 19);
            buttonLaunchDatabase.Margin = new Padding(3, 19, 3, 3);
            buttonLaunchDatabase.Name = "buttonLaunchDatabase";
            buttonLaunchDatabase.Padding = new Padding(0, 0, 10, 0);
            buttonLaunchDatabase.Size = new Size(362, 64);
            buttonLaunchDatabase.TabIndex = 12;
            buttonLaunchDatabase.Text = "Launch Database";
            buttonLaunchDatabase.UseVisualStyleBackColor = true;
            buttonLaunchDatabase.Click += ButtonLaunchDatabase_Click;
            // 
            // buttonQuitLauncher
            // 
            buttonQuitLauncher.Anchor = AnchorStyles.Top;
            buttonQuitLauncher.Cursor = Cursors.Hand;
            buttonQuitLauncher.FlatStyle = FlatStyle.Flat;
            buttonQuitLauncher.Location = new Point(4, 480);
            buttonQuitLauncher.Margin = new Padding(3, 35, 3, 35);
            buttonQuitLauncher.Name = "buttonQuitLauncher";
            buttonQuitLauncher.Size = new Size(362, 64);
            buttonQuitLauncher.TabIndex = 11;
            buttonQuitLauncher.Text = "Quit";
            buttonQuitLauncher.UseVisualStyleBackColor = true;
            buttonQuitLauncher.Click += ButtonQuitLauncher_Click;
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
            ClientSize = new Size(993, 659);
            Controls.Add(tabLauncher);
            Controls.Add(statusStrip);
            MinimizeBox = false;
            Name = "MainForm";
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
        private ToolStripStatusLabel tsStatusLabel;
        private Button buttonLaunchDatabase;
        private Button buttonQuitLauncher;
        private Button buttonLaunchGame;
        private Button buttonLaunchEnvironment;
        private Button button5;
        private Button button3;
        private Button button4;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Controls.XiUserConfigControl xiUserConfigControl;
    }
}
