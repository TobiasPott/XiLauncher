using ReaLTaiizor.Forms;
using xilauncher.Configuration;
using xilauncher.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace xilauncher
{
    /*
    HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\PlayOnlineUS\SquareEnix\PlayOnlineViewer
    HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\PlayOnlineUS\SquareEnix\PlayOnlineViewer\Settings

    FullScreen 			0   (?? 0 or 1) 
    Language			1   (?? unclear)
    PlayAudio			1   (?? 0 or 1)
    PlayOpeningMovie	1   (?? 0 or 1)
    ResetSettings		0   (?? 0 or 1)
    SupportLanguage		1   (?? unclear)
    UseGameController	0   (?? 0 or 1)
    WindowH				480 (?? width in pixel)
    WindowW				640 (?? height in pixel)
    WindowX				256 (?? x position on screen)
    WindowY				256 (?? x position on screen)
        */
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
            pbStartGame.Enabled = _launcher.Resources.IsLoaderAvailable;
            pbOpenGameLog.Enabled = _launcher.Resources.IsLoaderAvailable;

            pbStartEnvironment.Enabled = _launcher.Resources.IsEnvironmentAvailable;
            pbStartXiConnect.Enabled = pbViewLogXiConnect.Enabled = pbOpenConnectLog.Enabled = _launcher.Resources.IsXiConnectAvailable;
            pbStartXiSearch.Enabled = pbViewLogXiSearch.Enabled = pbOpenSearchLog.Enabled = _launcher.Resources.IsXiSearchAvailable;
            pbStartXiWorld.Enabled = pbViewLogXiWorld.Enabled = pbOpenWorldLog.Enabled = _launcher.Resources.IsXiWorldAvailable;
            pbStartXiMap.Enabled = pbViewLogXiMap.Enabled = pbOpenMapLog.Enabled = _launcher.Resources.IsXiMapAvailable;

            pbStartDatabase.Enabled = _launcher.Resources.IsDatabaseAvailable;
            pbOpenDatabaseLog.Enabled = pbViewLogDatabase.Enabled = _launcher.Resources.IsDatabaseAvailable;

            pbOpenConfigGame.Enabled = ExternalConfigrations.Instance.IsGameConfigSupported;
            pbOpenConfigGamepad.Enabled = ExternalConfigrations.Instance.IsGamepadConfigSupported;
            pbOpenConfigPlayOnline.Enabled = ExternalConfigrations.Instance.IsPlayOnlineConfigSupported;
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

        private void Launcher_ProcessChanged(LauncherModules modules, LauncherState state)
        {
            bool isStopped = state == LauncherState.Stopped || state == LauncherState.Stopping || state == LauncherState.Errored;
            bool isDisabled = state == LauncherState.Starting || state == LauncherState.Stopping;
            string text = (!isStopped ? UITexts.ButtonLabel_StopFormat : UITexts.ButtonLabel_LaunchFormat) + "{0}";
            Color backColor = (isStopped ? Color.IndianRed : Color.ForestGreen);

            Action<Button?, PictureBox?, LauncherModules> applyStatus = (button, pictureBox, module) =>
            {
                if (button != null)
                {
                    button.SetText(string.Format(text, module), 2);
                    button.Enabled = !isDisabled;
                }
                if (pictureBox != null)
                    pictureBox.BackColor = backColor;
            };

            this.Invoke(new Action(() =>
            {
                if (modules.HasFlag(LauncherModules.Loader)) applyStatus(pbStartGame, picStatusGame, LauncherModules.Loader);
                if (modules.HasFlag(LauncherModules.XiConnect)) applyStatus(pbStartXiConnect, picStatusConnect, LauncherModules.XiConnect);
                if (modules.HasFlag(LauncherModules.XiSearch)) applyStatus(pbStartXiSearch, picStatusSearch, LauncherModules.XiSearch);
                if (modules.HasFlag(LauncherModules.XiWorld)) applyStatus(pbStartXiWorld, picStatusWorld, LauncherModules.XiWorld);
                if (modules.HasFlag(LauncherModules.XiMap)) applyStatus(pbStartXiMap, picStatusMap, LauncherModules.XiMap);
                if (modules.HasFlag(LauncherModules.Environment)) applyStatus(pbStartEnvironment, null, LauncherModules.Environment);
                if (modules.HasFlag(LauncherModules.Database)) applyStatus(pbStartDatabase, picStatusDatabase, LauncherModules.Database);
            }));
        }

        private async void ButtonLaunchGame_Click(object sender, EventArgs e)
        {
            if (_launcher.IsLoaderProcessActive)
            {
                string message = String.Format($"Game{UITexts.MsgBox_Msg_IsRunning}");
                DialogResult result = ReaLTaiizor.Controls.PoisonMessageBox.Show(this, message, UITexts.MsgBox_Title_StopProcess,
                        MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    await _launcher.StopGame();
                }
            }
            else
            {
                this.userConfigControl.GetConfig(ref _currentAccount);
                if (await _launcher.LaunchGame(_currentAccount))
                {
                    LauncherSettings.Default.StoredAccount = _currentAccount;
                    LauncherSettings.Default.Save();
                }
            }
            await Task.CompletedTask;
        }
        private async void ButtonLaunchEnvironment_Click(object sender, EventArgs e)
        {
            if (_launcher.IsXiConnectActive)
            {
                string message = String.Format($"Environment{UITexts.MsgBox_Msg_IsRunning}");
                DialogResult result = ReaLTaiizor.Controls.PoisonMessageBox.Show(this, message, UITexts.MsgBox_Title_StopProcesses, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // ToDo: @tpott: introduce a launcher module type that is interfaced with "Start/Stop" 
                    //              this should allow to generalise these UI functions and identify what process to call by the flags provided
                    //          -> might instead add Strat/Stop with a LauncherModules argument to the Launcher type that internally directy to the correct module
                    //              this would be way less change with same result (and keeping it inside Launcher class)
                    await _launcher.StopEnvironment();
                }
            }
            else if (await _launcher.LaunchEnvironment())
            { }
            await Task.CompletedTask;
        }
        private async void ButtonLaunchXiConnect_Click(object sender, EventArgs e)
        {
            if (_launcher.IsEnvironmentActive)
            {
                string message = String.Format($"Xi Connect{UITexts.MsgBox_Msg_IsRunning}");
                DialogResult result = ReaLTaiizor.Controls.PoisonMessageBox.Show(this, message, UITexts.MsgBox_Title_StopProcess, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    await _launcher.StopXiConnectServer();
                }
            }
            else if (await _launcher.LaunchXiConnectServer(CancellationToken.None))
            { }
            await Task.CompletedTask;
        }
        private async void ButtonLaunchXiSearch_Click(object sender, EventArgs e)
        {
            if (_launcher.IsEnvironmentActive)
            {
                string message = String.Format($"Xi Search{UITexts.MsgBox_Msg_IsRunning}");
                DialogResult result = ReaLTaiizor.Controls.PoisonMessageBox.Show(this, message, UITexts.MsgBox_Title_StopProcess, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    await _launcher.StopXiSearchServer();
                }
            }
            else if (await _launcher.LaunchXiSearchServer(CancellationToken.None))
            { }
            await Task.CompletedTask;
        }
        private async void ButtonLaunchXiWorld_Click(object sender, EventArgs e)
        {
            if (_launcher.IsEnvironmentActive)
            {
                string message = String.Format($"Xi World{UITexts.MsgBox_Msg_IsRunning}");
                DialogResult result = ReaLTaiizor.Controls.PoisonMessageBox.Show(this, message, UITexts.MsgBox_Title_StopProcess, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    await _launcher.StopXiWorldServer();
                }
            }
            else if (await _launcher.LaunchXiWorldServer(CancellationToken.None))
            { }
            await Task.CompletedTask;
        }
        private async void ButtonLaunchXiMap_Click(object sender, EventArgs e)
        {
            if (_launcher.IsEnvironmentActive)
            {
                string message = String.Format($"Xi Map{UITexts.MsgBox_Msg_IsRunning}");
                DialogResult result = ReaLTaiizor.Controls.PoisonMessageBox.Show(this, message, UITexts.MsgBox_Title_StopProcess, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    await _launcher.StopXiMapServer();
                }
            }
            else if (await _launcher.LaunchXiMapServer(CancellationToken.None))
            { }
            await Task.CompletedTask;
        }

        private async void ButtonLaunchDatabase_Click(object sender, EventArgs e)
        {
            if (_launcher.IsDatabaseProcessActive)
            {
                string message = String.Format($"Database{UITexts.MsgBox_Msg_IsRunning}");
                DialogResult result = ReaLTaiizor.Controls.PoisonMessageBox.Show(this, message, UITexts.MsgBox_Title_StopProcess, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    await _launcher.StopDatabase();
                }
            }
            else if (await _launcher.LaunchDatabase())
            { }
            await Task.CompletedTask;
        }

        private async void ButtonQuitLauncher_Click(object sender, EventArgs e)
        {
            // check if any processes are active to prompt for confirmation
            if (_launcher.IsDatabaseProcessActive || _launcher.IsEnvironmentActive
                || _launcher.IsLoaderProcessActive)
            {
                string message = String.Format($"Processes are running. {Environment.NewLine}" +
                    $"Game:\t\t{(_launcher.IsLoaderProcessActive ? UITexts.Word_Running : UITexts.Word_Stopped)}{Environment.NewLine}" +
                    $"Database:\t{(_launcher.IsDatabaseProcessActive ? UITexts.Word_Running : UITexts.Word_Stopped)}{Environment.NewLine}" +
                    $"Server:\t\t{(_launcher.IsEnvironmentActive ? UITexts.Word_Running : UITexts.Word_Stopped)}{Environment.NewLine}" +
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


        //private Dictionary<XiLog.XiLogCategory, XiLogForm?> logForms = new Dictionary<XiLog.XiLogCategory, XiLogForm?>() {
        //    { XiLog.XiLogCategory.Database, null },
        //    { XiLog.XiLogCategory.ConnectServer, null },
        //    { XiLog.XiLogCategory.SearchServer, null },
        //    { XiLog.XiLogCategory.WorldServer, null },
        //    { XiLog.XiLogCategory.MapServer, null }
        //};

        private Controls.XiLogForm? logFormXiConnect;
        private void OpenLogXiConnectButton_Click(object sender, EventArgs e) =>
            XiLogForm.Open(ref logFormXiConnect, XiLog.XiLogCategory.ConnectServer, LogFormXiConnect_FormClosed);
        private void LogFormXiConnect_FormClosed(object? sender, FormClosedEventArgs e)
        { logFormXiConnect = null; this.Focus(); }

        private Controls.XiLogForm? logFormXiSearch;
        private void OpenLogXiSearchButton_Click(object sender, EventArgs e) =>
            XiLogForm.Open(ref logFormXiSearch, XiLog.XiLogCategory.SearchServer, LogFormXiSearch_FormClosed);
        private void LogFormXiSearch_FormClosed(object? sender, FormClosedEventArgs e)
        { logFormXiSearch = null; this.Focus(); }

        private Controls.XiLogForm? logFormXiWorld;
        private void OpenLogXiWorldButton_Click(object sender, EventArgs e) =>
            XiLogForm.Open(ref logFormXiWorld, XiLog.XiLogCategory.WorldServer, LogFormXiWorld_FormClosed);
        private void LogFormXiWorld_FormClosed(object? sender, FormClosedEventArgs e)
        { logFormXiWorld = null; this.Focus(); }

        private Controls.XiLogForm? logFormXiMap;
        private void OpenLogXiMapButton_Click(object sender, EventArgs e) =>
            XiLogForm.Open(ref logFormXiMap, XiLog.XiLogCategory.MapServer, LogFormXiMap_FormClosed);
        private void LogFormXiMap_FormClosed(object? sender, FormClosedEventArgs e)
        { logFormXiMap = null; this.Focus(); }


        private Controls.XiLogForm? logFormDatabase;
        private void OpenLogDatabaseButton_Click(object sender, EventArgs e) =>
            XiLogForm.Open(ref logFormDatabase, XiLog.XiLogCategory.Database, LogFormDatabase_FormClosed);
        private void LogFormDatabase_FormClosed(object? sender, FormClosedEventArgs e)
        { logFormDatabase = null; this.Focus(); }


        private void OpenGameConfigButton_Click(object sender, EventArgs e)
        {
            ExternalConfigrations.Instance.OpenConfigFor(ConfigApp.FinalFantasyXI);
        }

        private void OpenGamepadConfigButton_Click(object sender, EventArgs e)
        {
            ExternalConfigrations.Instance.OpenConfigFor(ConfigApp.Gamepad);
        }

        private void OpenPlayOnlineConfigButton_Click(object sender, EventArgs e)
        {
            ExternalConfigrations.Instance.OpenConfigFor(ConfigApp.PlayOnline);
        }

    }
}

