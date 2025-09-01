using System.Diagnostics;
using System.Text;

namespace xilauncher
{
    internal class XiLog
    {
        [Flags()]
        public enum XiLogCategory
        {
            Default = 0,
            Environment = 1,
            ConnectServer = 2,
            SearchServer = 4,
            WorldServer = 8,
            MapServer = 16,
            Database = 32,
            Loader = 64,
        }

        public enum XiLogLevel
        {
            Message,
            Error
        }
        [Flags()]
        public enum XiLogVisibility
        {
            All = Log | Console,
            Log = 1,
            Console = 2
        }

        public static event Action<XiLogCategory, XiLogLevel, string>? LogWritten;

        private static Dictionary<XiLogCategory, StringBuilder> _logChannels = new Dictionary<XiLogCategory, StringBuilder>();

        public const int LogBufferBaseSize = 65538;

        public static string GetLog(XiLogCategory category)
        {
            if (_logChannels.ContainsKey(category))
                return _logChannels[category].ToString();
            return string.Empty;
        }

        public static void WriteLine(string message,
            XiLogCategory category = XiLogCategory.Default,
            XiLogLevel level = XiLogLevel.Message,
            XiLogVisibility visibility = XiLogVisibility.All)
        {
            if (!_logChannels.ContainsKey(category))
                _logChannels[category] = new StringBuilder(LogBufferBaseSize, LogBufferBaseSize * 8);
            // [@{category}] <-- add to string to include cagegory in output
            string timestampedMessage = $"XiLog[#{level}] " +
                $"{DateTime.Now.ToString("yyyy-MM-dd")} {DateTime.Now.ToLongTimeString()}" +
                $": {message}";
            // get log string builder and remove first 65k if at max capacity
            StringBuilder sb = _logChannels[category];
            if (sb.Capacity >= (sb.MaxCapacity - timestampedMessage.Length))
                sb.Remove(0, LogBufferBaseSize);
            // log to channel buffer and console window



            if (visibility.HasFlag(XiLogVisibility.Console))
                Console.WriteLine(timestampedMessage);
            if (visibility.HasFlag(XiLogVisibility.Log))
            {
                sb.AppendLine($">> {message}");
                // call event to notify othery
                LogWritten?.Invoke(category, level, message);
            }
        }
    }


    internal class XiLogProcessRedirector
    {
        public static readonly XiLogProcessRedirector DatabaseRedirector = new XiLogProcessRedirector(XiLog.XiLogCategory.Database, visibility: XiLog.XiLogVisibility.Log);
        public static readonly XiLogProcessRedirector XiConnectRedirector = new XiLogProcessRedirector(XiLog.XiLogCategory.ConnectServer, visibility: XiLog.XiLogVisibility.Log);
        public static readonly XiLogProcessRedirector XiSearchRedirector = new XiLogProcessRedirector(XiLog.XiLogCategory.SearchServer, visibility: XiLog.XiLogVisibility.Log);
        public static readonly XiLogProcessRedirector XiWorldRedirector = new XiLogProcessRedirector(XiLog.XiLogCategory.WorldServer, visibility: XiLog.XiLogVisibility.Log);
        public static readonly XiLogProcessRedirector XiMapRedirector = new XiLogProcessRedirector(XiLog.XiLogCategory.MapServer, visibility: XiLog.XiLogVisibility.Log);


        public readonly XiLog.XiLogCategory Category;
        public readonly XiLog.XiLogLevel OutputAs;
        public readonly XiLog.XiLogLevel ErrorAs;
        public readonly XiLog.XiLogVisibility Visibility;
        private Process? _process = null;

        public XiLogProcessRedirector(XiLog.XiLogCategory category, XiLog.XiLogLevel outputAs = XiLog.XiLogLevel.Message,
            XiLog.XiLogLevel errorAs = XiLog.XiLogLevel.Error, XiLog.XiLogVisibility visibility = XiLog.XiLogVisibility.All)
        {
            this.Category = category;
            this.OutputAs = outputAs;
            this.ErrorAs = errorAs;
            this.Visibility = visibility;
        }

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
