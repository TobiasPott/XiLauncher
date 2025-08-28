using Microsoft.Win32;

namespace xilauncher.Controls
{
    public partial class XiExternalConfigControl : UserControl
    {

        RegistryKey? regKeyIinstallFolders = Registry.LocalMachine.OpenSubKey("Software", false)?
            .OpenSubKey("WOW6432Node", false)?
                .OpenSubKey("PlayOnlineUS", false)?
                .OpenSubKey("InstallFolder", false);

        FileInfo? ffxiGameConfigExe;
        FileInfo? ffxiGamepadConfigExe;
        FileInfo? ffxiPolConfigExe;


        public XiExternalConfigControl()
        {
            InitializeComponent();

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

        private void ButtonConfigGamepad_Click(object sender, EventArgs e)
        {
            Launcher.Launch(ffxiGamepadConfigExe, "", null, false, true, "runas");
        }

        private void ButtonConfigFFXI_Click(object sender, EventArgs e)
        {
            Launcher.Launch(ffxiGameConfigExe, "", null, false, true, "runas");
        }

        private void ButtonConfigPlayOnline_Click(object sender, EventArgs e)
        {
            Launcher.Launch(ffxiPolConfigExe, "", null, false, true, "runas");
        }
    }
}
