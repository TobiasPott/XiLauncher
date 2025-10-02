namespace xilauncher
{
    public struct ProcessParams
    {
        public static readonly ProcessParams Default = new ProcessParams();
        public static readonly ProcessParams DefaultUseShell = new ProcessParams(useShell: true);


        public string Args;
        public bool EnableEvents;
        public bool UseShell;
        public string Verb;
        public bool RedirectStreams;

        public ProcessParams()
        {
            this.Args = string.Empty;
            this.EnableEvents = true;
            this.UseShell = false;
            this.Verb = string.Empty;
            this.RedirectStreams = true;
        }
        public ProcessParams(string args = "", bool enableEvents = true, bool useShell = false, string verb = "", bool redirectStreams = true)
        {
            this.Args = args;
            this.EnableEvents = enableEvents;
            this.UseShell = useShell;
            this.Verb = verb;
            this.RedirectStreams = redirectStreams;
        }
        public static  ProcessParams DefaultWithArgs(string args = "", bool redirectStreams = true)
        {
            ProcessParams result = Default;
            result.Args = args;
            result.RedirectStreams = redirectStreams;
            return result;
        }
        public static ProcessParams Shell(string args = "", bool enableEvents = true, string verb = "", bool redirectStreams = true)
        {
            ProcessParams result = DefaultUseShell;
            result.Args = args;
            result.EnableEvents = enableEvents;
            result.Verb = verb;
            result.RedirectStreams = redirectStreams;
            return result;
        }

        // "", true, false, "", true
    }

}
