namespace xilauncher.Configuration
{
    internal sealed class LauncherSettings : global::System.Configuration.ApplicationSettingsBase
    {

        private static LauncherSettings defaultInstance = ((LauncherSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new LauncherSettings())));
        public static LauncherSettings Default => defaultInstance;


        [global::System.Configuration.UserScopedSettingAttribute()]
        public XiLoaderUserConfig? StoredAccount
        {
            get => ((XiLoaderUserConfig)(this["StoredAccount"]));
            set => this["StoredAccount"] = value;
        }

    }
}
