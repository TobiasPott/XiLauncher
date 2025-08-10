namespace xilauncher.Controls
{
    partial class XiUserConfigControl
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
            label3 = new Label();
            textBoxUsername = new TextBox();
            checkBoxHairpin = new CheckBox();
            label2 = new Label();
            textBoxPassword = new TextBox();
            label1 = new Label();
            textBoxServer = new TextBox();
            bindingSource1 = new BindingSource(components);
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 37);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 34;
            label3.Text = "Login";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUsername.Location = new Point(106, 34);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(147, 31);
            textBoxUsername.TabIndex = 33;
            // 
            // checkBoxHairpin
            // 
            checkBoxHairpin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxHairpin.CheckAlign = ContentAlignment.MiddleRight;
            checkBoxHairpin.Location = new Point(3, 149);
            checkBoxHairpin.Name = "checkBoxHairpin";
            checkBoxHairpin.Size = new Size(250, 29);
            checkBoxHairpin.TabIndex = 32;
            checkBoxHairpin.Text = "Hairpin";
            checkBoxHairpin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 74);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 31;
            label2.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.Location = new Point(106, 71);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(147, 31);
            textBoxPassword.TabIndex = 30;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 115);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 29;
            label1.Text = "Server";
            // 
            // textBoxServer
            // 
            textBoxServer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxServer.Location = new Point(106, 112);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.Size = new Size(147, 31);
            textBoxServer.TabIndex = 26;
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
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Cursor = Cursors.Hand;
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(3, 184);
            button1.Name = "button1";
            button1.Size = new Size(250, 65);
            button1.TabIndex = 27;
            button1.Text = "New Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // XiUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxUsername);
            Controls.Add(checkBoxHairpin);
            Controls.Add(label2);
            Controls.Add(textBoxPassword);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBoxServer);
            Name = "XiUserControl";
            Size = new Size(256, 252);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBoxUsername;
        private CheckBox checkBoxHairpin;
        private Label label2;
        private TextBox textBoxPassword;
        private Label label1;
        private TextBox textBoxServer;
        private BindingSource bindingSource1;
        private Label label4;
        private Button button1;
    }
}
