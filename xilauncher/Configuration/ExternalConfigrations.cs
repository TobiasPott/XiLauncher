using Microsoft.Win32;
using System.Diagnostics;

namespace xilauncher.Configuration
{
    public enum ConfigApp
    {
        PlayOnline,
        FinalFantasyXI,
        Gamepad
    }

    internal class ExternalConfigrations
    {

        public static ExternalConfigrations Instance { get; private set; } = new ExternalConfigrations();


        private RegistryKey? regKeyIinstallFolders = Registry.LocalMachine.OpenSubKey("Software", false)?
            .OpenSubKey("WOW6432Node", false)?
                .OpenSubKey("PlayOnlineUS", false)?
                .OpenSubKey("InstallFolder", false);

        private FileInfo? ffxiGameConfigExe;
        private FileInfo? ffxiGamepadConfigExe;
        private FileInfo? ffxiPolConfigExe;

        public ExternalConfigrations()
        {

            if (regKeyIinstallFolders != null)
            {
                // ToDo: change to use .ToDirectoryInfo/ToFileInfo extensions and cleanup constant strings

                string ffxiBasePath = regKeyIinstallFolders.GetValue("0001")?.ToString() ?? string.Empty;
                string polBasePath = regKeyIinstallFolders.GetValue("1000")?.ToString() ?? string.Empty;
                XiLog.WriteLine(ffxiBasePath);
                XiLog.WriteLine(polBasePath);
                ffxiGamepadConfigExe = new FileInfo(Path.Combine(ffxiBasePath, "ToolsUS", "FFXiPadConfig.exe"));
                ffxiGameConfigExe = new FileInfo(Path.Combine(ffxiBasePath, "ToolsUS", "FINAL FANTASY XI Config.exe"));
                ffxiPolConfigExe = new FileInfo(Path.Combine(polBasePath, "polcfg", "polcfg.exe"));

                // polcfg / polcfg.exe (runas admin)
                // Tools(US/EU) / FFXiPadConfig.exe
                // Tools(US/EU) / FINAL FANTASY XI Config.exe
                XiLog.WriteLine(ffxiGameConfigExe.FullName + ": " + ffxiGameConfigExe.Exists);
                XiLog.WriteLine(ffxiGamepadConfigExe.FullName + ": " + ffxiGamepadConfigExe.Exists);
                XiLog.WriteLine(ffxiPolConfigExe.FullName + ": " + ffxiPolConfigExe.Exists);

            }
        }

        public Process? OpenConfigFor(ConfigApp configApp)
        {
            switch (configApp)
            {
                case ConfigApp.PlayOnline:
                    return OpenConfigForPlayOnline();
                case ConfigApp.FinalFantasyXI:
                    return OpenConfigForFinalFantasyXI();
                case ConfigApp.Gamepad:
                    return OpenConfigForGamepad();
            }
            return null;
        }
        public Process? OpenConfigForGamepad()
        {
            return Launcher.Launch(ffxiGamepadConfigExe, "", null, false, true, "runas");
        }

        public Process? OpenConfigForFinalFantasyXI()
        {
            return Launcher.Launch(ffxiGameConfigExe, "", null, false, true, "runas");
        }
        public Process? OpenConfigForPlayOnline()
        {
            return Launcher.Launch(ffxiPolConfigExe, "", null, false, true, "runas");
        }
    }
}
