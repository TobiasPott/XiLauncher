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
            toggleHairpin = new ReaLTaiizor.Controls.PoisonToggle();
            textBoxUsername = new ReaLTaiizor.Controls.PoisonTextBox();
            textBoxPassword = new ReaLTaiizor.Controls.PoisonTextBox();
            textBoxServer = new ReaLTaiizor.Controls.PoisonTextBox();
            toggleCreateAccount = new ReaLTaiizor.Controls.PoisonToggle();
            poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            poisonLabel2 = new ReaLTaiizor.Controls.PoisonLabel();
            poisonLabel3 = new ReaLTaiizor.Controls.PoisonLabel();
            poisonLabel4 = new ReaLTaiizor.Controls.PoisonLabel();
            poisonLabel5 = new ReaLTaiizor.Controls.PoisonLabel();
            poisonPanel1 = new ReaLTaiizor.Controls.PoisonPanel();
            poisonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // toggleHairpin
            // 
            toggleHairpin.AutoSize = true;
            toggleHairpin.FontSize = ReaLTaiizor.Extension.Poison.PoisonLinkLabelSize.Medium;
            toggleHairpin.Location = new Point(151, 159);
            toggleHairpin.Name = "toggleHairpin";
            toggleHairpin.Size = new Size(80, 29);
            toggleHairpin.TabIndex = 36;
            toggleHairpin.Text = "Aus";
            toggleHairpin.UseSelectable = true;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            textBoxUsername.CustomButton.Image = null;
            textBoxUsername.CustomButton.Location = new Point(139, 2);
            textBoxUsername.CustomButton.Name = "";
            textBoxUsername.CustomButton.Size = new Size(29, 29);
            textBoxUsername.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxUsername.CustomButton.TabIndex = 1;
            textBoxUsername.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxUsername.CustomButton.UseSelectable = true;
            textBoxUsername.CustomButton.Visible = false;
            textBoxUsername.FontSize = ReaLTaiizor.Extension.Poison.PoisonTextBoxSize.Tall;
            textBoxUsername.Lines = new string[]
    {
    "mule"
    };
            textBoxUsername.Location = new Point(151, 4);
            textBoxUsername.MaxLength = 32767;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PasswordChar = '\0';
            textBoxUsername.ScrollBars = ScrollBars.None;
            textBoxUsername.SelectedText = "";
            textBoxUsername.SelectionLength = 0;
            textBoxUsername.SelectionStart = 0;
            textBoxUsername.ShortcutsEnabled = true;
            textBoxUsername.Size = new Size(171, 34);
            textBoxUsername.TabIndex = 37;
            textBoxUsername.Text = "mule";
            textBoxUsername.UseSelectable = true;
            textBoxUsername.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxUsername.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            textBoxPassword.CustomButton.Image = null;
            textBoxPassword.CustomButton.Location = new Point(139, 2);
            textBoxPassword.CustomButton.Name = "";
            textBoxPassword.CustomButton.Size = new Size(29, 29);
            textBoxPassword.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxPassword.CustomButton.TabIndex = 1;
            textBoxPassword.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxPassword.CustomButton.UseSelectable = true;
            textBoxPassword.CustomButton.Visible = false;
            textBoxPassword.FontSize = ReaLTaiizor.Extension.Poison.PoisonTextBoxSize.Tall;
            textBoxPassword.Lines = new string[]
    {
    "private"
    };
            textBoxPassword.Location = new Point(151, 44);
            textBoxPassword.MaxLength = 32767;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.ScrollBars = ScrollBars.None;
            textBoxPassword.SelectedText = "";
            textBoxPassword.SelectionLength = 0;
            textBoxPassword.SelectionStart = 0;
            textBoxPassword.ShortcutsEnabled = true;
            textBoxPassword.Size = new Size(171, 34);
            textBoxPassword.TabIndex = 38;
            textBoxPassword.Text = "private";
            textBoxPassword.UseSelectable = true;
            textBoxPassword.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxPassword.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // textBoxServer
            // 
            textBoxServer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            textBoxServer.CustomButton.Image = null;
            textBoxServer.CustomButton.Location = new Point(139, 2);
            textBoxServer.CustomButton.Name = "";
            textBoxServer.CustomButton.Size = new Size(29, 29);
            textBoxServer.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            textBoxServer.CustomButton.TabIndex = 1;
            textBoxServer.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            textBoxServer.CustomButton.UseSelectable = true;
            textBoxServer.CustomButton.Visible = false;
            textBoxServer.FontSize = ReaLTaiizor.Extension.Poison.PoisonTextBoxSize.Tall;
            textBoxServer.Lines = new string[]
    {
    "127.0.0.1"
    };
            textBoxServer.Location = new Point(151, 119);
            textBoxServer.MaxLength = 32767;
            textBoxServer.Name = "textBoxServer";
            textBoxServer.PasswordChar = '\0';
            textBoxServer.ScrollBars = ScrollBars.None;
            textBoxServer.SelectedText = "";
            textBoxServer.SelectionLength = 0;
            textBoxServer.SelectionStart = 0;
            textBoxServer.ShortcutsEnabled = true;
            textBoxServer.Size = new Size(171, 34);
            textBoxServer.TabIndex = 39;
            textBoxServer.Text = "127.0.0.1";
            textBoxServer.UseSelectable = true;
            textBoxServer.WaterMarkColor = Color.FromArgb(109, 109, 109);
            textBoxServer.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // toggleCreateAccount
            // 
            toggleCreateAccount.AutoSize = true;
            toggleCreateAccount.FontSize = ReaLTaiizor.Extension.Poison.PoisonLinkLabelSize.Medium;
            toggleCreateAccount.Location = new Point(151, 84);
            toggleCreateAccount.Name = "toggleCreateAccount";
            toggleCreateAccount.Size = new Size(80, 29);
            toggleCreateAccount.TabIndex = 41;
            toggleCreateAccount.Text = "Aus";
            toggleCreateAccount.UseSelectable = true;
            toggleCreateAccount.Visible = false;
            // 
            // poisonLabel1
            // 
            poisonLabel1.AutoSize = true;
            poisonLabel1.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            poisonLabel1.Location = new Point(3, 163);
            poisonLabel1.Name = "poisonLabel1";
            poisonLabel1.Size = new Size(67, 25);
            poisonLabel1.TabIndex = 42;
            poisonLabel1.Text = "Hairpin";
            // 
            // poisonLabel2
            // 
            poisonLabel2.AutoSize = true;
            poisonLabel2.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            poisonLabel2.Location = new Point(3, 128);
            poisonLabel2.Name = "poisonLabel2";
            poisonLabel2.Size = new Size(60, 25);
            poisonLabel2.TabIndex = 43;
            poisonLabel2.Text = "Server";
            // 
            // poisonLabel3
            // 
            poisonLabel3.AutoSize = true;
            poisonLabel3.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            poisonLabel3.Location = new Point(3, 13);
            poisonLabel3.Name = "poisonLabel3";
            poisonLabel3.Size = new Size(89, 25);
            poisonLabel3.TabIndex = 44;
            poisonLabel3.Text = "Username";
            // 
            // poisonLabel4
            // 
            poisonLabel4.AutoSize = true;
            poisonLabel4.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            poisonLabel4.Location = new Point(3, 53);
            poisonLabel4.Name = "poisonLabel4";
            poisonLabel4.Size = new Size(82, 25);
            poisonLabel4.TabIndex = 45;
            poisonLabel4.Text = "Password";
            // 
            // poisonLabel5
            // 
            poisonLabel5.AutoSize = true;
            poisonLabel5.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            poisonLabel5.Location = new Point(4, 88);
            poisonLabel5.Name = "poisonLabel5";
            poisonLabel5.Size = new Size(128, 25);
            poisonLabel5.TabIndex = 46;
            poisonLabel5.Text = "Create Account";
            poisonLabel5.Visible = false;
            // 
            // poisonPanel1
            // 
            poisonPanel1.AutoSize = true;
            poisonPanel1.Controls.Add(toggleHairpin);
            poisonPanel1.Controls.Add(textBoxUsername);
            poisonPanel1.Controls.Add(textBoxPassword);
            poisonPanel1.Controls.Add(textBoxServer);
            poisonPanel1.Controls.Add(toggleCreateAccount);
            poisonPanel1.Controls.Add(poisonLabel1);
            poisonPanel1.Controls.Add(poisonLabel5);
            poisonPanel1.Controls.Add(poisonLabel2);
            poisonPanel1.Controls.Add(poisonLabel3);
            poisonPanel1.Controls.Add(poisonLabel4);
            poisonPanel1.Dock = DockStyle.Fill;
            poisonPanel1.HorizontalScrollbarBarColor = true;
            poisonPanel1.HorizontalScrollbarHighlightOnWheel = false;
            poisonPanel1.HorizontalScrollbarSize = 10;
            poisonPanel1.Location = new Point(0, 0);
            poisonPanel1.Name = "poisonPanel1";
            poisonPanel1.Size = new Size(325, 196);
            poisonPanel1.TabIndex = 47;
            poisonPanel1.VerticalScrollbarBarColor = true;
            poisonPanel1.VerticalScrollbarHighlightOnWheel = false;
            poisonPanel1.VerticalScrollbarSize = 10;
            // 
            // XiUserConfigControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(poisonPanel1);
            Name = "XiUserConfigControl";
            Size = new Size(325, 196);
            poisonPanel1.ResumeLayout(false);
            poisonPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.PoisonToggle toggleHairpin;
        private ReaLTaiizor.Controls.PoisonTextBox textBoxUsername;
        private ReaLTaiizor.Controls.PoisonTextBox textBoxPassword;
        private ReaLTaiizor.Controls.PoisonTextBox textBoxServer;
        private ReaLTaiizor.Controls.PoisonToggle toggleCreateAccount;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel2;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel3;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel4;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel5;
        private ReaLTaiizor.Controls.PoisonPanel poisonPanel1;
    }
}
