using System.Security;
using System.Text;

namespace xilauncher
{

    // Empty config type to map the registry keys of the PlayOnline Viewer to
    //      these can control the UI game settings for launched instances (not sure if only PlayOnline or also FFXI)
    [Serializable]
    public struct XiLoaderPolConfig
    {
        public XiLoaderPolConfig()
        {
        }

        public XiLoaderPolConfig(string userName, string unsafePassword, string server, bool hairpin)
        {
        }

        public string ToArguments()
        {
            return string.Empty;
        }
    }

}
