namespace xilauncher
{
    internal static class Program
    {
        private static Launcher _launcher;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            _launcher = new Launcher();
            Application.Run(new MainForm(_launcher));
        }
    }
}