using System.Text;

namespace xilauncher
{
    public class XiLog
    {
        /// <summary>
        /// Enumeration of log categories used by the launcher application
        /// </summary>
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
        /// <summary>
        /// Enumeration of log level (mostly there to reflect StdErr and StdOut on monitored processes)
        /// </summary>
        public enum XiLogLevel
        {
            Message,
            Error
        }
        /// <summary>
        /// Enumeration of log message visibility
        /// </summary>
        [Flags()]
        public enum XiLogVisibility
        {
            All = Log | Console,
            Log = 1,
            Console = 2
        }

        /// <summary>
        /// maximum buffer size and used to trim the log history
        /// </summary>
        public const int LogBufferBaseSize = 65538;

        /// <summary>
        /// event fired when a new message is written to the log
        /// </summary>
        public static event Action<XiLogCategory, XiLogLevel, string>? LogWritten;

        private static Dictionary<XiLogCategory, StringBuilder> _logChannels = new Dictionary<XiLogCategory, StringBuilder>();

        /// <summary>
        /// gets the entire log for the given category
        /// </summary>
        /// <param name="category">the category to get the log for (only individual values)</param>
        /// <returns>the entire log as a string (might be slow on longer logs)</returns>
        public static string GetLog(XiLogCategory category)
        {
            if (_logChannels.ContainsKey(category))
                return _logChannels[category].ToString();
            return string.Empty;
        }

        /// <summary>
        /// Writes a new message line to a xi log
        /// </summary>
        /// <param name="message">the message to write to the log/console</param>
        /// <param name="category">category the message belongs to</param>
        /// <param name="level">the message's level to indicate non-standard messages</param>
        /// <param name="visibility">where the message is visible when written</param>
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

}
