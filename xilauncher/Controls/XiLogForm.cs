using ReaLTaiizor.Forms;

namespace xilauncher.Controls
{
    public partial class XiLogForm : PoisonForm
    {
        internal XiLog.XiLogCategory Category { get; set; } = XiLog.XiLogCategory.Default;

        public event Action<string>? LineRead;

        public XiLogForm()
        {
            InitializeComponent();
        }

        private void LogForm_Activated(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                string logContent = XiLog.GetLog(Category);
                ptOut.Clear();
                ptOut.AppendText(logContent);
                ptOut.Invalidate(true);
            }));
            XiLog.LogWritten += XiLog_LogWritten;
        }

        private void XiLog_LogWritten(XiLog.XiLogCategory arg1, XiLog.XiLogLevel arg2, string arg3)
        {
            if (arg1 == Category)
            {
                this.BeginInvoke(new Action(() =>
                {
                    ptOut.AppendText(arg3 + Environment.NewLine);
                }));
            }
        }

        private void LogForm_Deactivate(object sender, EventArgs e)
        {
            XiLog.LogWritten -= XiLog_LogWritten;
        }

        private void LogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            XiLog.LogWritten -= XiLog_LogWritten;
        }

        private void ptIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            string input = ptIn.Text;
            if (!string.IsNullOrWhiteSpace(input))
            {
                LineRead?.Invoke(input);
            }
            ptIn.Clear();
        }
    }
}
