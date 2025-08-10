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
            panel1 = new Panel();
            buttonLaunchDatabase = new Button();
            buttonQuitLauncher = new Button();
            buttonLaunchGame = new Button();
            buttonLaunchEnvironment = new Button();
            tabMonitor = new TabPage();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            statusStrip.SuspendLayout();
            tabLauncher.SuspendLayout();
            tabLaunch.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { tsStatusLabel });
            statusStrip.Location = new Point(0, 482);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(628, 32);
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
            tabLauncher.Controls.Add(tabMonitor);
            tabLauncher.Dock = DockStyle.Fill;
            tabLauncher.Location = new Point(0, 0);
            tabLauncher.Name = "tabLauncher";
            tabLauncher.SelectedIndex = 0;
            tabLauncher.Size = new Size(628, 482);
            tabLauncher.TabIndex = 3;
            // 
            // tabLaunch
            // 
            tabLaunch.Controls.Add(panel1);
            tabLaunch.Location = new Point(4, 34);
            tabLaunch.Name = "tabLaunch";
            tabLaunch.Padding = new Padding(3);
            tabLaunch.Size = new Size(620, 444);
            tabLaunch.TabIndex = 0;
            tabLaunch.Text = "Launch";
            tabLaunch.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(buttonLaunchDatabase);
            panel1.Controls.Add(buttonQuitLauncher);
            panel1.Controls.Add(buttonLaunchGame);
            panel1.Controls.Add(buttonLaunchEnvironment);
            panel1.Location = new Point(8, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(604, 432);
            panel1.TabIndex = 9;
            // 
            // buttonLaunchDatabase
            // 
            buttonLaunchDatabase.Anchor = AnchorStyles.Top;
            buttonLaunchDatabase.Cursor = Cursors.Hand;
            buttonLaunchDatabase.FlatStyle = FlatStyle.Flat;
            buttonLaunchDatabase.Image = Properties.Resources.clear_x32;
            buttonLaunchDatabase.ImageAlign = ContentAlignment.MiddleRight;
            buttonLaunchDatabase.Location = new Point(174, 214);
            buttonLaunchDatabase.Name = "buttonLaunchDatabase";
            buttonLaunchDatabase.Padding = new Padding(0, 0, 10, 0);
            buttonLaunchDatabase.Size = new Size(256, 64);
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
            buttonQuitLauncher.Location = new Point(174, 338);
            buttonQuitLauncher.Name = "buttonQuitLauncher";
            buttonQuitLauncher.Size = new Size(256, 64);
            buttonQuitLauncher.TabIndex = 11;
            buttonQuitLauncher.Text = "Quit";
            buttonQuitLauncher.UseVisualStyleBackColor = true;
            buttonQuitLauncher.Click += ButtonQuitLauncher_Click;
            // 
            // buttonLaunchGame
            // 
            buttonLaunchGame.Anchor = AnchorStyles.Top;
            buttonLaunchGame.Cursor = Cursors.Hand;
            buttonLaunchGame.Enabled = false;
            buttonLaunchGame.FlatStyle = FlatStyle.Flat;
            buttonLaunchGame.Location = new Point(174, 31);
            buttonLaunchGame.Name = "buttonLaunchGame";
            buttonLaunchGame.Size = new Size(256, 64);
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
            buttonLaunchEnvironment.Location = new Point(174, 118);
            buttonLaunchEnvironment.Name = "buttonLaunchEnvironment";
            buttonLaunchEnvironment.Size = new Size(256, 64);
            buttonLaunchEnvironment.TabIndex = 9;
            buttonLaunchEnvironment.Text = "Launch Environment";
            buttonLaunchEnvironment.UseVisualStyleBackColor = true;
            buttonLaunchEnvironment.Click += ButtonLaunchEnvironment_Click;
            // 
            // tabMonitor
            // 
            tabMonitor.Location = new Point(4, 34);
            tabMonitor.Name = "tabMonitor";
            tabMonitor.Padding = new Padding(3);
            tabMonitor.Size = new Size(620, 444);
            tabMonitor.TabIndex = 1;
            tabMonitor.Text = "Monitor";
            tabMonitor.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(452, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 31);
            textBox1.TabIndex = 16;
            textBox1.UseSystemPasswordChar = true;
            textBox1.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(452, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 31);
            textBox2.TabIndex = 17;
            textBox2.UseSystemPasswordChar = true;
            textBox2.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 514);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip;
        private TabControl tabLauncher;
        private TabPage tabLaunch;
        private TabPage tabMonitor;
        private ToolStripStatusLabel tsStatusLabel;
        private Panel panel1;
        private Button buttonLaunchDatabase;
        private Button buttonQuitLauncher;
        private Button buttonLaunchGame;
        private Button buttonLaunchEnvironment;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
