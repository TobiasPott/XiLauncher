namespace xilauncher.Configuration
{
    //[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    //[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.14.0.0")]
    internal sealed partial class LauncherSettings : global::System.Configuration.ApplicationSettingsBase
    {

        private static LauncherSettings defaultInstance = ((LauncherSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new LauncherSettings())));
        public static LauncherSettings Default => defaultInstance;


        [global::System.Configuration.UserScopedSettingAttribute()]
        public XiLoaderUserConfig StoredAccount
        {
            get => ((XiLoaderUserConfig)(this["StoredAccount"]));
            set => this["StoredAccount"] = value;
        }

        //[global::System.Configuration.UserScopedSettingAttribute()]
        //public XiLoaderUserConfig[] RecentUsers
        //{
        //    get => ((XiLoaderUserConfig[])(this["RecentUsers"]));
        //    set => this["RecentUsers"] = value;
        //}
    }
}
