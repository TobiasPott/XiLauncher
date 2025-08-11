using System.Security;
using System.Text;

namespace xilauncher
{
    [Serializable]
    public struct XiLoaderConfig
    {
        public string Username = "";
        public SecureString Password = new SecureString();
        public string Server = "127.0.0.1"; // localhost is default to connect to launched environment
        public bool UseHairPin = false;
        public XiLoaderConfig()
        {
        }

        public XiLoaderConfig(string userName, string unsafePassword, string server, bool hairpin)
        {
            Username = userName;
            Password = new System.Security.SecureString();
            foreach (char c in unsafePassword) Password.AppendChar(c);
            Server = server;
            UseHairPin = hairpin;
        }

        public string ToArguments()
        {
            StringBuilder sb = new StringBuilder();
            string pass = new System.Net.NetworkCredential(string.Empty, this.Password).Password;

            if (!String.IsNullOrWhiteSpace(Username)) sb.Append($"--user {this.Username} ");
            if (!String.IsNullOrWhiteSpace(pass)) sb.Append($"--pass {pass} ");
            if (!String.IsNullOrWhiteSpace(Server)) sb.Append($"--server {this.Server} ");
            if (this.UseHairPin) sb.Append("--hairpin ");
            return sb.ToString();
        }
    }

}
