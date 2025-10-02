namespace xilauncher.Configuration
{
    internal sealed class LauncherSettings : global::System.Configuration.ApplicationSettingsBase
    {
        public static LauncherSettings Default { get; } = ((LauncherSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new LauncherSettings())));


        [global::System.Configuration.UserScopedSettingAttribute()]
        public XiLoaderUserConfig? StoredAccount
        {
            get => ((XiLoaderUserConfig)(this["StoredAccount"]));
            set => this["StoredAccount"] = value;
        }

    }
}
