using System.Security;
using System.Text;

namespace xilauncher
{
    [Serializable]
    public struct XiLoaderUserConfig
    {
        public string Username = "";
        public SecureString Password = new SecureString();
        public string Server = "127.0.0.1"; // localhost is default to connect to launched environment
        public bool UseHairPin = false;
        public bool CreateAccount = false;
        public XiLoaderUserConfig()
        {
        }

        public XiLoaderUserConfig(string userName, string unsafePassword, string server, bool hairpin)
        {
            Username = userName;
            Password = new System.Security.SecureString();
            foreach (char c in unsafePassword) Password.AppendChar(c);
            Server = server;
            UseHairPin = hairpin;
            CreateAccount = false;
        }

        public string ToArguments()
        {
            StringBuilder sb = new StringBuilder();
            string pass = new System.Net.NetworkCredential(string.Empty, this.Password).Password;

            if (!String.IsNullOrWhiteSpace(Username)) sb.Append($"--user {this.Username} ");
            if (!String.IsNullOrWhiteSpace(pass)) sb.Append($"--pass {pass} ");
            if (!String.IsNullOrWhiteSpace(Server)) sb.Append($"--server {this.Server} ");
            if (this.UseHairPin) sb.Append("--hairpin ");

            // ToDo: add 'createAccount' as --create to the xi loader arguments assembled here
            return sb.ToString();
        }
    }

}
