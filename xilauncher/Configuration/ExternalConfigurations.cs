using Microsoft.Win32;
using System.Diagnostics;

namespace xilauncher.Configuration
{
    /// <summary>
    /// Enumeration of external configuration apps provided via external applications
    /// </summary>
    public enum ConfigApp
    {
        PlayOnline,
        FinalFantasyXI,
        Gamepad
    }

    internal class ExternalConfigurations
    {
        /// <summary>
        /// singleton instance which provides access to the external configuration apps
        /// </summary>
        public static ExternalConfigurations Instance { get; private set; } = new ExternalConfigurations();


        private RegistryKey? regKeyIinstallFolders = Registry.LocalMachine
            .OpenSubKey("Software", false)?
            .OpenSubKey("WOW6432Node", false)?
            .OpenSubKey("PlayOnlineUS", false)?
            .OpenSubKey("InstallFolder", false);

        private FileInfo? ffxiGameConfigExe;
        private FileInfo? ffxiGamepadConfigExe;
        private FileInfo? ffxiPolConfigExe;

        /// <summary>
        /// gets whether the game config can be opened by the caller
        /// </summary>
        public bool IsGameConfigSupported => ffxiGameConfigExe != null && ffxiGameConfigExe.Exists;
        /// <summary>
        /// gets whether the gamepad/controller config can be opened by the caller
        /// </summary>
        public bool IsGamepadConfigSupported => ffxiGamepadConfigExe != null && ffxiGamepadConfigExe.Exists;
        /// <summary>
        /// gets whether the PlayOnline config can be opened by the caller
        /// </summary>
        public bool IsPlayOnlineConfigSupported => ffxiPolConfigExe != null && ffxiPolConfigExe.Exists;


        private ExternalConfigurations()
        {

            if (regKeyIinstallFolders != null)
            {
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

        /// <summary>
        /// Opens the provided external configuration app
        /// </summary>
        /// <param name="configApp">the configuration app to open</param>
        /// <returns>the process for the started config app, or null if app couldn't be started.</returns>
        public Process? OpenConfigFor(ConfigApp configApp)
        {
            switch (configApp)
            {
                case ConfigApp.PlayOnline:
                    return Launcher.Launch(ffxiPolConfigExe, null, ProcessParams.Shell(enableEvents: false, verb: "runas"));
                case ConfigApp.FinalFantasyXI:
                    return Launcher.Launch(ffxiGameConfigExe, null, ProcessParams.Shell(enableEvents: false, verb: "runas"));
                case ConfigApp.Gamepad:
                    return Launcher.Launch(ffxiGamepadConfigExe, null, ProcessParams.Shell(enableEvents: false, verb: "runas"));
            }
            return null;
        }

    }
}
