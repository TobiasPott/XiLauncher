using ReaLTaiizor.Forms;
using xilauncher.Configuration;
using xilauncher.Controls;

namespace xilauncher
{
    public partial class MainForm : PoisonForm
    {
        /// <summary>
        /// reference to the internal launcher instance used to handle environment processes
        /// </summary>
        private readonly Launcher _launcher;
        /// <summary>
        /// the 'default' mule account used in the development environment data sample
        /// </summary>
        private XiLoaderUserConfig _currentAccount = new XiLoaderUserConfig("mule", "", "127.0.0.1", true);


        public MainForm(Launcher launcher) : base()
        {
            InitializeComponent();
            _launcher = launcher;
            _launcher.ProcessChanged += Launcher_ProcessChanged;
            _launcher.Resources.Refreshed += Resources_Refreshed;
            _launcher.Resources.RefreshResources();

            this.poisonTabControl1.DisableTab(this.tabPageLogs);

            // load previously used account/user
            XiLoaderUserConfig? lastAccount = LauncherSettings.Default.StoredAccount;
            if (lastAccount != null)
            {
                if (!String.IsNullOrWhiteSpace(lastAccount.Username))
                    _currentAccount = lastAccount;
            }
            this.userConfigControl.SetConfig(_currentAccount);
        }

        /// <summary>
        /// refreshes the resources the launcher use (don't use while processes are running)
        /// </summary>
        private void Resources_Refreshed()
        {
            poisonLabel1.Text = _launcher.Resources.dirBase.FullName;
            XiLog.WriteLine("Refreshed to: " + _launcher.Resources.dirBase.FullName);

            // update button states based on availability of resources and external files
            pbStartGame.Enabled = _launcher.Resources.IsAvailable(Launcher.EModules.Loader);
            pbOpenGameLog.Enabled = _launcher.Resources.IsAvailable(Launcher.EModules.Loader);

            pbStartEnvironment.Enabled = _launcher.Resources.IsAvailable(Launcher.EModules.Environment);
            pbStartXiConnect.Enabled = pbViewLogXiConnect.Enabled = pbOpenConnectLog.Enabled = _launcher.Resources.IsAvailable(Launcher.EModules.XiConnect);
            pbStartXiSearch.Enabled = pbViewLogXiSearch.Enabled = pbOpenSearchLog.Enabled = _launcher.Resources.IsAvailable(Launcher.EModules.XiSearch);
            pbStartXiWorld.Enabled = pbViewLogXiWorld.Enabled = pbOpenWorldLog.Enabled = _launcher.Resources.IsAvailable(Launcher.EModules.XiWorld);
            pbStartXiMap.Enabled = pbViewLogXiMap.Enabled = pbOpenMapLog.Enabled = _launcher.Resources.IsAvailable(Launcher.EModules.XiMap);

            pbStartDatabase.Enabled = _launcher.Resources.IsAvailable(Launcher.EModules.Database);
            pbOpenDatabaseLog.Enabled = pbViewLogDatabase.Enabled = _launcher.Resources.IsAvailable(Launcher.EModules.Database);

            pbOpenConfigGame.Enabled = ExternalConfigurations.Instance.IsGameConfigSupported;
            pbOpenConfigGamepad.Enabled = ExternalConfigurations.Instance.IsGamepadConfigSupported;
            pbOpenConfigPlayOnline.Enabled = ExternalConfigurations.Instance.IsPlayOnlineConfigSupported;
        }

        /// <summary>
        /// called when close is requested, stops all environment processes and shuts down the application
        /// </summary>
        /// <returns></returns>
        private async Task CloseApplication()
        {
            _launcher.ProcessChanged -= Launcher_ProcessChanged;
            await _launcher.Exit(true, true, true);
            this.Close();
        }

        private void Launcher_ProcessChanged(Launcher.EModules modules, ELauncherState state)
        {
            bool isStopped = state == ELauncherState.Stopped || state == ELauncherState.Stopping || state == ELauncherState.Errored;
            bool isDisabled = state == ELauncherState.Starting || state == ELauncherState.Stopping;
  
            string text = (!isStopped ? UITexts.ButtonLabel_StopFormat : UITexts.ButtonLabel_LaunchFormat) + "{0}";
            Color backColor = (isStopped ? Color.IndianRed : Color.ForestGreen);

            // ToDo: @tpott: environment button label does not reset correctly to 'launch..' when all xi servers are stopped individually
            Action<Button?, PictureBox?, Launcher.EModules> applyStatus = (button, pictureBox, module) =>
            {
                if (button != null)
                {
                    button.SetText(string.Format(text, Launcher.ModuleNames[module]), 2);
                    button.Enabled = !isDisabled;
                }
                if (pictureBox != null)
                    pictureBox.BackColor = backColor;
            };

            this.Invoke(new Action(() =>
            {
                if (modules.HasFlag(Launcher.EModules.Loader)) applyStatus(pbStartGame, picStatusGame, Launcher.EModules.Loader);
                if (modules.HasFlag(Launcher.EModules.XiConnect)) applyStatus(pbStartXiConnect, picStatusConnect, Launcher.EModules.XiConnect);
                if (modules.HasFlag(Launcher.EModules.XiSearch)) applyStatus(pbStartXiSearch, picStatusSearch, Launcher.EModules.XiSearch);
                if (modules.HasFlag(Launcher.EModules.XiWorld)) applyStatus(pbStartXiWorld, picStatusWorld, Launcher.EModules.XiWorld);
                if (modules.HasFlag(Launcher.EModules.XiMap)) applyStatus(pbStartXiMap, picStatusMap, Launcher.EModules.XiMap);
                if (modules.HasFlag(Launcher.EModules.Environment)) applyStatus(pbStartEnvironment, null, Launcher.EModules.Environment);
                if (modules.HasFlag(Launcher.EModules.Database)) applyStatus(pbStartDatabase, picStatusDatabase, Launcher.EModules.Database);
            }));
        }


        private async void ButtonLaunchGame_Click(object sender, EventArgs e)
        {
            if (await _launcher.StartModule(Launcher.EModules.Database))
            {
                // save changes to launcher settings (e.g. stored account)
                LauncherSettings.Default.Save();
            }
        }
        private async void ButtonLaunchEnvironment_Click(object sender, EventArgs e) => await _launcher.StartModule(Launcher.EModules.Environment);
        private async void ButtonLaunchXiConnect_Click(object sender, EventArgs e) => await _launcher.StartModule(Launcher.EModules.XiConnect);
        private async void ButtonLaunchXiSearch_Click(object sender, EventArgs e) => await _launcher.StartModule(Launcher.EModules.XiSearch);
        private async void ButtonLaunchXiWorld_Click(object sender, EventArgs e) => await _launcher.StartModule(Launcher.EModules.XiWorld);
        private async void ButtonLaunchXiMap_Click(object sender, EventArgs e) => await _launcher.StartModule(Launcher.EModules.XiMap);
        private async void ButtonLaunchDatabase_Click(object sender, EventArgs e) => await _launcher.StartModule(Launcher.EModules.Database);
        private async void ButtonQuitLauncher_Click(object sender, EventArgs e)
        {
            bool activeDatabase = _launcher.IsProcessActive(Launcher.EModules.Database);
            bool activeEnvironment = _launcher.IsProcessActive(Launcher.EModules.Environment);
            bool activeLoader = _launcher.IsProcessActive(Launcher.EModules.Loader);
            // check if any processes are active to prompt for confirmation
            if (activeDatabase || activeEnvironment || activeLoader)
            {
                string message = String.Format($"Processes are running. {Environment.NewLine}" +
                    $"Game:\t\t{(activeLoader ? UITexts.Word_Running : UITexts.Word_Stopped)}{Environment.NewLine}" +
                    $"Database:\t{(activeDatabase ? UITexts.Word_Running : UITexts.Word_Stopped)}{Environment.NewLine}" +
                    $"Server:\t\t{(activeEnvironment ? UITexts.Word_Running : UITexts.Word_Stopped)}{Environment.NewLine}" +
                    $"{Environment.NewLine}");
                DialogResult result = ReaLTaiizor.Controls.PoisonMessageBox.Show(this, message, "Stop processes and Quit?", MessageBoxButtons.YesNo, this.Height);
                if (result == DialogResult.Yes)
                {
                    await this.CloseApplication();
                }
            }
            else
                await this.CloseApplication();

            await Task.CompletedTask;
        }


        private XiLogForm? logFormXiConnect;
        private void OpenLogXiConnectButton_Click(object sender, EventArgs e) => XiLogForm.Open(ref logFormXiConnect, XiLog.XiLogCategory.ConnectServer, LogFormXiConnect_FormClosed);
        private void LogFormXiConnect_FormClosed(object? sender, FormClosedEventArgs e)
        { logFormXiConnect = null; this.Focus(); }


        private XiLogForm? logFormXiSearch;
        private void OpenLogXiSearchButton_Click(object sender, EventArgs e) => XiLogForm.Open(ref logFormXiSearch, XiLog.XiLogCategory.SearchServer, LogFormXiSearch_FormClosed);
        private void LogFormXiSearch_FormClosed(object? sender, FormClosedEventArgs e)
        { logFormXiSearch = null; this.Focus(); }


        private XiLogForm? logFormXiWorld;
        private void OpenLogXiWorldButton_Click(object sender, EventArgs e) => XiLogForm.Open(ref logFormXiWorld, XiLog.XiLogCategory.WorldServer, LogFormXiWorld_FormClosed);
        private void LogFormXiWorld_FormClosed(object? sender, FormClosedEventArgs e)
        { logFormXiWorld = null; this.Focus(); }


        private XiLogForm? logFormXiMap;
        private void OpenLogXiMapButton_Click(object sender, EventArgs e) => XiLogForm.Open(ref logFormXiMap, XiLog.XiLogCategory.MapServer, LogFormXiMap_FormClosed);
        private void LogFormXiMap_FormClosed(object? sender, FormClosedEventArgs e)
        { logFormXiMap = null; this.Focus(); }


        private XiLogForm? logFormDatabase;
        private void OpenLogDatabaseButton_Click(object sender, EventArgs e) => XiLogForm.Open(ref logFormDatabase, XiLog.XiLogCategory.Database, LogFormDatabase_FormClosed);
        private void LogFormDatabase_FormClosed(object? sender, FormClosedEventArgs e)
        { logFormDatabase = null; this.Focus(); }


        private void OpenGameConfigButton_Click(object sender, EventArgs e) => ExternalConfigurations.Instance.OpenConfigFor(ConfigApp.FinalFantasyXI);
        private void OpenGamepadConfigButton_Click(object sender, EventArgs e) => ExternalConfigurations.Instance.OpenConfigFor(ConfigApp.Gamepad);
        private void OpenPlayOnlineConfigButton_Click(object sender, EventArgs e) => ExternalConfigurations.Instance.OpenConfigFor(ConfigApp.PlayOnline);

    }
}

