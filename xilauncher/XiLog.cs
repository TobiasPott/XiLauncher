namespace xilauncher
{
    internal class XiLog
    {
        [Flags()]
        public enum LogCategory
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
        public static void WriteLine(string message, LogCategory category = LogCategory.Default)
        {
            // 2025-08-10 19:38:54 0
            Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd")} {DateTime.Now.ToLongTimeString()} XiLog[@{category}]: {message}");
        }
    }
}
