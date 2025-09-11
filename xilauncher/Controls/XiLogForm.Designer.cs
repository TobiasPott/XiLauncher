namespace xilauncher.Controls
{
    partial class XiLogForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ptOut = new ReaLTaiizor.Controls.PoisonTextBox();
            ptIn = new ReaLTaiizor.Controls.PoisonTextBox();
            SuspendLayout();
            // 
            // ptOut
            // 
            ptOut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            ptOut.CustomButton.Image = null;
            ptOut.CustomButton.Location = new Point(432, 2);
            ptOut.CustomButton.Name = "";
            ptOut.CustomButton.Size = new Size(325, 325);
            ptOut.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            ptOut.CustomButton.TabIndex = 1;
            ptOut.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            ptOut.CustomButton.UseSelectable = true;
            ptOut.CustomButton.Visible = false;
            ptOut.FontSize = ReaLTaiizor.Extension.Poison.PoisonTextBoxSize.Medium;
            ptOut.Lines = new string[]
    {
    "poisonTextBox1"
    };
            ptOut.Location = new Point(20, 60);
            ptOut.MaxLength = 32767;
            ptOut.Multiline = true;
            ptOut.Name = "ptOut";
            ptOut.PasswordChar = '\0';
            ptOut.ReadOnly = true;
            ptOut.ScrollBars = ScrollBars.None;
            ptOut.SelectedText = "";
            ptOut.SelectionLength = 0;
            ptOut.SelectionStart = 0;
            ptOut.ShortcutsEnabled = true;
            ptOut.Size = new Size(760, 330);
            ptOut.TabIndex = 2;
            ptOut.Text = "poisonTextBox1";
            ptOut.UseSelectable = true;
            ptOut.WaterMarkColor = Color.FromArgb(109, 109, 109);
            ptOut.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // ptIn
            // 
            // 
            // 
            // 
            ptIn.CustomButton.Image = null;
            ptIn.CustomButton.Location = new Point(728, 2);
            ptIn.CustomButton.Name = "";
            ptIn.CustomButton.Size = new Size(29, 29);
            ptIn.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            ptIn.CustomButton.TabIndex = 1;
            ptIn.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            ptIn.CustomButton.UseSelectable = true;
            ptIn.CustomButton.Visible = false;
            ptIn.Dock = DockStyle.Bottom;
            ptIn.FontSize = ReaLTaiizor.Extension.Poison.PoisonTextBoxSize.Tall;
            ptIn.Location = new Point(20, 396);
            ptIn.MaxLength = 32767;
            ptIn.Name = "ptIn";
            ptIn.PasswordChar = '\0';
            ptIn.ScrollBars = ScrollBars.None;
            ptIn.SelectedText = "";
            ptIn.SelectionLength = 0;
            ptIn.SelectionStart = 0;
            ptIn.ShortcutsEnabled = true;
            ptIn.ShowClearButton = true;
            ptIn.Size = new Size(760, 34);
            ptIn.TabIndex = 1;
            ptIn.UseSelectable = true;
            ptIn.WaterMarkColor = Color.FromArgb(109, 109, 109);
            ptIn.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            ptIn.KeyPress += ptIn_KeyPress;
            // 
            // XiLogForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(255, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(ptIn);
            Controls.Add(ptOut);
            ForeColor = SystemColors.HighlightText;
            Name = "XiLogForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "LogForm";
            FormClosing += LogForm_FormClosing;
            Load += LogForm_Activated;
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.PoisonTextBox ptOut;
        private ReaLTaiizor.Controls.PoisonTextBox ptIn;
    }
}