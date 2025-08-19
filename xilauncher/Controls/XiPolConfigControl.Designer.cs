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
            buttonConfigGamepad = new Button();
            buttonConfigFFXI = new Button();
            notifyIcon1 = new NotifyIcon(components);
            buttonConfigPlayOnline = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // buttonConfigGamepad
            // 
            buttonConfigGamepad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonConfigGamepad.Cursor = Cursors.Hand;
            buttonConfigGamepad.FlatAppearance.BorderSize = 2;
            buttonConfigGamepad.FlatStyle = FlatStyle.Flat;
            buttonConfigGamepad.Image = Properties.Resources.FFXI_ExeIcon;
            buttonConfigGamepad.ImageAlign = ContentAlignment.MiddleLeft;
            buttonConfigGamepad.Location = new Point(3, 6);
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
            buttonConfigFFXI.FlatAppearance.BorderSize = 2;
            buttonConfigFFXI.FlatStyle = FlatStyle.Flat;
            buttonConfigFFXI.Image = Properties.Resources.FFXI_ExeIcon;
            buttonConfigFFXI.ImageAlign = ContentAlignment.MiddleLeft;
            buttonConfigFFXI.Location = new Point(3, 79);
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
            buttonConfigPlayOnline.FlatAppearance.BorderSize = 2;
            buttonConfigPlayOnline.FlatStyle = FlatStyle.Flat;
            buttonConfigPlayOnline.Image = Properties.Resources.Pol_ExeIcon;
            buttonConfigPlayOnline.ImageAlign = ContentAlignment.MiddleLeft;
            buttonConfigPlayOnline.Location = new Point(3, 152);
            buttonConfigPlayOnline.Margin = new Padding(3, 6, 3, 6);
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
            Controls.Add(buttonConfigPlayOnline);
            Controls.Add(buttonConfigFFXI);
            Controls.Add(buttonConfigGamepad);
            Name = "XiPolConfigControl";
            Size = new Size(212, 222);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource bindingSource1;
        private Button buttonConfigGamepad;
        private Button buttonConfigFFXI;
        private NotifyIcon notifyIcon1;
        private Button buttonConfigPlayOnline;
    }
}
