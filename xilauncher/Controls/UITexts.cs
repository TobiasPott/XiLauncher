namespace xilauncher
{
    internal class UITexts
    {
        public const string ButtonLabel_StopFormat = "Stop ";
        public const string ButtonLabel_LaunchFormat = "Launch ";
        public const string ButtonLabel_StopFormatSpaced = "  Stop ";
        public const string ButtonLabel_LaunchFormatSpaced = "  Launch ";
    }
}


public static class UIExtensions
{
    public static void SetText(this Button button, string text, int leadingSpaces = 0)
    {
        button.Text = leadingSpaces > 0 ? text.PadLeft(text.Length + leadingSpaces) : text;
    }

}