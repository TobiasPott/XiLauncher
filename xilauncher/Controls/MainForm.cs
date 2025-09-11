using ReaLTaiizor.Forms;
using xilauncher.Configuration;

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
        private readonly Launcher _launcher;
        private XiLoaderUserConfig _default = new XiLoaderUserConfig("mule", "private", "127.0.0.1", true);


        public MainForm(Launcher launcher) : base()
        {
            InitializeComponent();
            _launcher = launcher;
            _launcher.ProcessChanged += Launcher_ProcessChanged;
            _launcher.Resources.Refreshed += Resources_Refreshed;
            _launcher.Resources.RefreshResources();

        }

        private void Resources_Refreshed()
        {
            poisonLabel1.Text = _launcher.Resources.dirBase.FullName;
            XiLog.WriteLine("Refreshed to: " + _launcher.Resources.dirBase.FullName);

            // update button states based on availability of resources and external files
            pbStartGame.Enabled = _launcher.Resources.IsGameLaunchSupported;
            pbOpenGameLog.Enabled = _launcher.Resources.IsGameLaunchSupported;

            pbStartEnvironment.Enabled = _launcher.Resources.IsEnvironmentLaunchSupported;
            pbOpenConnectLog.Enabled = _launcher.Resources.IsEnvironmentLaunchSupported;
            pbOpenSearchLog.Enabled = _launcher.Resources.IsEnvironmentLaunchSupported;
            pbOpenWorldLog.Enabled = _launcher.Resources.IsEnvironmentLaunchSupported;
            pbOpenMapLog.Enabled = _launcher.Resources.IsEnvironmentLaunchSupported;

            pbStartDatabase.Enabled = _launcher.Resources.IsDatabaseLaunchSupported;
            pbOpenDatabaseLog.Enabled = _launcher.Resources.IsDatabaseLaunchSupported;


            pbOpenConfigGame.Enabled = ExternalConfigrations.Instance.IsGameConfigSupported;
            pbOpenConfigGamepad.Enabled = ExternalConfigrations.Instance.IsGamepadConfigSupported;
            pbOpenConfigPlayOnline.Enabled = ExternalConfigrations.Instance.IsPlayOnlineConfigSupported;
        }

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
            string text = (!isStopped ? UITexts.ButtonLabel_StopFormat : UITexts.ButtonLabel_LaunchFormat) + " {0}";
            Color backColor = (isStopped ? Color.IndianRed : Color.ForestGreen);

            Action<Button?, PictureBox?, LauncherModules> applyStatus = (button, pictureBox, module) =>
            {
                if (button != null)
                {
                    button.Text = string.Format(text, module);
                    button.Enabled = !isDisabled;
                }
                if (pictureBox != null)
                    pictureBox.BackColor = backColor;
            };

            this.Invoke(new Action(() =>
            {
                if (modules.HasFlag(LauncherModules.Loader)) applyStatus(pbStartGame, pbStatusGame, LauncherModules.Loader);
                if (modules.HasFlag(LauncherModules.ConnectServer)) applyStatus(null, pbStatusConnect, LauncherModules.ConnectServer);
                if (modules.HasFlag(LauncherModules.SearchServer)) applyStatus(null, pbStatusSearch, LauncherModules.SearchServer);
                if (modules.HasFlag(LauncherModules.WorldServer)) applyStatus(null, pbStatusWorld, LauncherModules.WorldServer);
                if (modules.HasFlag(LauncherModules.MapServer)) applyStatus(null, pbStatusMap, LauncherModules.MapServer);
                if (modules.HasFlag(LauncherModules.Environment)) applyStatus(pbStartEnvironment, null, LauncherModules.Environment);
                if (modules.HasFlag(LauncherModules.Database)) applyStatus(pbStartDatabase, pbStatusDatabase, LauncherModules.Database);
            }));
        }

        private async void ButtonLaunchGame_Click(object sender, EventArgs e)
        {
            if (_launcher.IsGameProcessActive)
            { await _launcher.StopGame(); }
            else if (await _launcher.LaunchGame(_default))
            { }
            await Task.CompletedTask;
        }
        private async void ButtonLaunchEnvironment_Click(object sender, EventArgs e)
        {
            if (_launcher.IsEnvironmentActive)
            { await _launcher.StopEnvironment(); }
            else if (await _launcher.LaunchEnvironment())
            { }
            await Task.CompletedTask;
        }
        private async void ButtonLaunchDatabase_Click(object sender, EventArgs e)
        {
            if (_launcher.IsDatabaseProcessActive)
            { await _launcher.StopDatabase(); }
            else if (await _launcher.LaunchDatabase())
            { }
            await Task.CompletedTask;
        }

        private async void ButtonQuitLauncher_Click(object sender, EventArgs e)
        {
            // check if any processes are active to prompt for confirmation
            DialogResult result = DialogResult.Yes;
            if (_launcher.IsDatabaseProcessActive || _launcher.IsEnvironmentActive
                || _launcher.IsGameProcessActive)
            {
                string message = String.Format($"Processes are still running. {Environment.NewLine}" +
                    $"Game:\t\t{(_launcher.IsGameProcessActive ? "running" : "stopped")}{Environment.NewLine}" +
                    $"Database:\t{(_launcher.IsDatabaseProcessActive ? "running" : "stopped")}{Environment.NewLine}" +
                    $"Server:\t\t{(_launcher.IsEnvironmentActive ? "running" : "stopped")}{Environment.NewLine}" +
                    $"{Environment.NewLine}");
                result = MessageBox.Show(message, "Stop processes and Quit?", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    await this.CloseApplication();
                }
            }
            if (result == System.Windows.Forms.DialogResult.Yes)
                await this.CloseApplication();
            await Task.CompletedTask;
        }



        private Controls.XiLogForm? logFormXiConnect;
        private void OpenLogXiConnectButton_Click(object sender, EventArgs e) =>
            OpenLog(ref logFormXiConnect, XiLog.XiLogCategory.ConnectServer, LogFormXiConnect_FormClosed);
        private void LogFormXiConnect_FormClosed(object? sender, FormClosedEventArgs e)
        { logFormXiConnect = null; this.Focus(); }

        private Controls.XiLogForm? logFormXiSearch;
        private void OpenLogXiSearchButton_Click(object sender, EventArgs e) =>
            OpenLog(ref logFormXiSearch, XiLog.XiLogCategory.SearchServer, LogFormXiSearch_FormClosed);
        private void LogFormXiSearch_FormClosed(object? sender, FormClosedEventArgs e)
        { logFormXiSearch = null; this.Focus(); }

        private Controls.XiLogForm? logFormXiWorld;
        private void OpenLogXiWorldButton_Click(object sender, EventArgs e) =>
            OpenLog(ref logFormXiWorld, XiLog.XiLogCategory.WorldServer, LogFormXiWorld_FormClosed);
        private void LogFormXiWorld_FormClosed(object? sender, FormClosedEventArgs e)
        { logFormXiWorld = null; this.Focus(); }

        private Controls.XiLogForm? logFormXiMap;
        private void OpenLogXiMapButton_Click(object sender, EventArgs e) =>
            OpenLog(ref logFormXiMap, XiLog.XiLogCategory.MapServer, LogFormXiMap_FormClosed);
        private void LogFormXiMap_FormClosed(object? sender, FormClosedEventArgs e)
        { logFormXiMap = null; this.Focus(); }


        private Controls.XiLogForm? logFormDatabase;
        private void OpenLogDatabaseButton_Click(object sender, EventArgs e) =>
            OpenLog(ref logFormDatabase, XiLog.XiLogCategory.Database, LogFormDatabase_FormClosed);
        private void LogFormDatabase_FormClosed(object? sender, FormClosedEventArgs e)
        { logFormDatabase = null; this.Focus(); }


        private void OpenLog(ref Controls.XiLogForm? form, XiLog.XiLogCategory category, FormClosedEventHandler? onFormClosed)
        {
            if (form == null)
            {
                form = new Controls.XiLogForm();
                form.Text = $"Log - {category}";
                form.Category = category;
                // init log form;
                form.FormClosed += onFormClosed;
            }
            form.Show();
        }


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

