using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xilauncher.Controls
{
    public partial class LogForm : Form
    {
        //private System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();

        internal XiLog.XiLogCategory Category { get; set; } = XiLog.XiLogCategory.Default;

        public LogForm()
        {
            InitializeComponent();
        }

        private void LogForm_Activated(object sender, EventArgs e)
        {
            // ToDo: @tpott: add event to XiLog which is called on each Write.. call with the given string and category
            //_timer.Tick += Timer_Tick;
            //_timer.Interval = 1000;
            //_timer.Start();

            this.BeginInvoke(new Action(() =>
            {
                string logContent = XiLog.GetLog(Category);
                textBox1.Clear();
                textBox1.AppendText(logContent);
                //textBox1.Select(logContent.Length, 0);
                //textBox1.ScrollToCaret();
                this.textBox1.Invalidate(true);
            }));
            XiLog.LogWritten += XiLog_LogWritten;
        }

        private void XiLog_LogWritten(XiLog.XiLogCategory arg1, XiLog.XiLogLevel arg2, string arg3)
        {
            if (arg1 == Category)
            {
                this.BeginInvoke(new Action(() =>
                {
                    textBox1.AppendText(arg3 + Environment.NewLine);
                }));
            }
        }

        private void LogForm_Deactivate(object sender, EventArgs e)
        {
            //_timer.Tick -= Timer_Tick;
            //_timer.Interval = 5000;
            //_timer.Stop();
            XiLog.LogWritten -= XiLog_LogWritten;
        }

        private void LogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            XiLog.LogWritten -= XiLog_LogWritten;
        }
    }
}
