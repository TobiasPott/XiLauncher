using System.Diagnostics;

namespace xilauncher
{
    internal class XiLogProcessRedirector
    {
        /// <summary>
        /// log redirector for the database process
        /// </summary>
        public static readonly XiLogProcessRedirector DatabaseRedirector = new XiLogProcessRedirector(XiLog.XiLogCategory.Database, visibility: XiLog.XiLogVisibility.Log);

        /// <summary>
        /// log redirector for the xi connect server process
        /// </summary>
        public static readonly XiLogProcessRedirector XiConnectRedirector = new XiLogProcessRedirector(XiLog.XiLogCategory.ConnectServer, visibility: XiLog.XiLogVisibility.Log);

        /// <summary>
        /// log redirector for the xi search server process
        /// </summary>
        public static readonly XiLogProcessRedirector XiSearchRedirector = new XiLogProcessRedirector(XiLog.XiLogCategory.SearchServer, visibility: XiLog.XiLogVisibility.Log);

        /// <summary>
        /// log redirector for the xi world server process
        /// </summary>
        public static readonly XiLogProcessRedirector XiWorldRedirector = new XiLogProcessRedirector(XiLog.XiLogCategory.WorldServer, visibility: XiLog.XiLogVisibility.Log);

        /// <summary>
        /// log redirector for the xi map server process
        /// </summary>
        public static readonly XiLogProcessRedirector XiMapRedirector = new XiLogProcessRedirector(XiLog.XiLogCategory.MapServer, visibility: XiLog.XiLogVisibility.Log);


        /// <summary>
        /// the category the redirected messages are logged to
        /// </summary>
        public readonly XiLog.XiLogCategory Category;
        /// <summary>
        /// the level the output message stream is logged as
        /// </summary>
        public readonly XiLog.XiLogLevel OutputAs;
        /// <summary>
        /// the level the error message stream is logged as
        /// </summary>
        public readonly XiLog.XiLogLevel ErrorAs;
        /// <summary>
        /// the visibility all messages are logged with
        /// </summary>
        public readonly XiLog.XiLogVisibility Visibility;
        private Process? _process = null;

        private XiLogProcessRedirector(XiLog.XiLogCategory category, XiLog.XiLogLevel outputAs = XiLog.XiLogLevel.Message,
            XiLog.XiLogLevel errorAs = XiLog.XiLogLevel.Error, XiLog.XiLogVisibility visibility = XiLog.XiLogVisibility.All)
        {
            this.Category = category;
            this.OutputAs = outputAs;
            this.ErrorAs = errorAs;
            this.Visibility = visibility;
        }

        /// <summary>
        /// Attach the redirector to the given process
        /// </summary>
        /// <param name="process">the process to attach to and redirect the standard output and error streams</param>
        public void Attach(Process? process)
        {
            if (_process is not null)
                this.Detach();

            // enable output and error retrieval
            if (process is not null)
            {
                process.OutputDataReceived += Process_OutputDataReceived;
                process.ErrorDataReceived += Process_ErrorDataReceived;
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                _process = process;
            }
        }
        /// <summary>
        /// Detach from the current attached process, does nothing if not attached.
        /// </summary>
        public void Detach()
        {
            // enable output and error retrieval
            if (_process is not null)
            {
                _process.OutputDataReceived -= Process_OutputDataReceived;
                _process.ErrorDataReceived -= Process_ErrorDataReceived;
                _process.CancelOutputRead();
                _process.CancelErrorRead();
                _process = null;
            }
        }

        private void Process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            string log = $"{e.Data}";
            if (!String.IsNullOrWhiteSpace(log))
                XiLog.WriteLine(log, Category, ErrorAs, Visibility);
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            string log = $"{e.Data}";
            if (!String.IsNullOrWhiteSpace(log))
                XiLog.WriteLine(log, Category, OutputAs, Visibility);
        }

    }

}
