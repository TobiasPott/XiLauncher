namespace xilauncher
{
    internal class UITexts
    {
        public const string ButtonLabel_StopFormat = "Stop ";
        public const string ButtonLabel_LaunchFormat = "Launch ";


        public const string MsgBox_Msg_IsRunning = " is running.";
        public const string MsgBox_Title_StopProcess = "Stop process?";
        public const string MsgBox_Title_StopProcesses = "Stop processes?";

        public const string Word_Running = "running";
        public const string Word_Stopped = "stopped";

    }

    internal class RegistryTexts
    {
        public const string Software = "Software";
        public const string WOW6432Node = "WOW6432Node";
        public const string PlayOnline = "PlayOnlineUS";
        public const string InstallFolder = "InstallFolder";
    }
}


public static class UIExtensions
{
    public static void SetText(this Button button, string text, int leadingSpaces = 0)
    {
        button.Text = leadingSpaces > 0 ? text.PadLeft(text.Length + leadingSpaces) : text;
    }

}