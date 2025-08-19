namespace xilauncher.Controls
{
    partial class XiPolConfigControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            label4 = new Label();
            buttonConfigGamepad = new Button();
            buttonConfigFFXI = new Button();
            notifyIcon1 = new NotifyIcon(components);
            buttonConfigPlayOnline = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(3, 3, 3, 6);
            label4.Name = "label4";
            label4.Padding = new Padding(3);
            label4.Size = new Size(127, 31);
            label4.TabIndex = 35;
            label4.Text = "Configuration";
            // 
            // buttonConfigGamepad
            // 
            buttonConfigGamepad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonConfigGamepad.Cursor = Cursors.Hand;
            buttonConfigGamepad.FlatStyle = FlatStyle.Flat;
            buttonConfigGamepad.Image = Properties.Resources.FFXI_ExeIcon;
            buttonConfigGamepad.ImageAlign = ContentAlignment.MiddleLeft;
            buttonConfigGamepad.Location = new Point(3, 41);
            buttonConfigGamepad.Margin = new Padding(3, 6, 3, 3);
            buttonConfigGamepad.MinimumSize = new Size(0, 64);
            buttonConfigGamepad.Name = "buttonConfigGamepad";
            buttonConfigGamepad.Padding = new Padding(12, 0, 12, 0);
            buttonConfigGamepad.Size = new Size(206, 64);
            buttonConfigGamepad.TabIndex = 48;
            buttonConfigGamepad.Text = " Gamepad";
            buttonConfigGamepad.TextAlign = ContentAlignment.MiddleLeft;
            buttonConfigGamepad.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonConfigGamepad.UseVisualStyleBackColor = true;
            // 
            // buttonConfigFFXI
            // 
            buttonConfigFFXI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonConfigFFXI.Cursor = Cursors.Hand;
            buttonConfigFFXI.FlatStyle = FlatStyle.Flat;
            buttonConfigFFXI.Image = Properties.Resources.FFXI_ExeIcon;
            buttonConfigFFXI.ImageAlign = ContentAlignment.MiddleLeft;
            buttonConfigFFXI.Location = new Point(3, 114);
            buttonConfigFFXI.Margin = new Padding(3, 6, 3, 3);
            buttonConfigFFXI.MinimumSize = new Size(0, 64);
            buttonConfigFFXI.Name = "buttonConfigFFXI";
            buttonConfigFFXI.Padding = new Padding(12, 0, 12, 0);
            buttonConfigFFXI.Size = new Size(206, 64);
            buttonConfigFFXI.TabIndex = 49;
            buttonConfigFFXI.Text = " Final Fantasy XI";
            buttonConfigFFXI.TextAlign = ContentAlignment.MiddleLeft;
            buttonConfigFFXI.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonConfigFFXI.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // buttonConfigPlayOnline
            // 
            buttonConfigPlayOnline.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonConfigPlayOnline.Cursor = Cursors.Hand;
            buttonConfigPlayOnline.FlatStyle = FlatStyle.Flat;
            buttonConfigPlayOnline.Image = Properties.Resources.Pol_ExeIcon;
            buttonConfigPlayOnline.ImageAlign = ContentAlignment.MiddleLeft;
            buttonConfigPlayOnline.Location = new Point(3, 187);
            buttonConfigPlayOnline.Margin = new Padding(3, 6, 3, 3);
            buttonConfigPlayOnline.MinimumSize = new Size(0, 64);
            buttonConfigPlayOnline.Name = "buttonConfigPlayOnline";
            buttonConfigPlayOnline.Padding = new Padding(12, 0, 12, 0);
            buttonConfigPlayOnline.Size = new Size(206, 64);
            buttonConfigPlayOnline.TabIndex = 50;
            buttonConfigPlayOnline.Text = " PlayOnline";
            buttonConfigPlayOnline.TextAlign = ContentAlignment.MiddleLeft;
            buttonConfigPlayOnline.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonConfigPlayOnline.UseVisualStyleBackColor = true;
            // 
            // XiPolConfigControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(buttonConfigPlayOnline);
            Controls.Add(buttonConfigFFXI);
            Controls.Add(buttonConfigGamepad);
            Controls.Add(label4);
            Name = "XiPolConfigControl";
            Size = new Size(212, 254);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource bindingSource1;
        private Label label4;
        private Button buttonConfigGamepad;
        private Button buttonConfigFFXI;
        private NotifyIcon notifyIcon1;
        private Button buttonConfigPlayOnline;
    }
}
