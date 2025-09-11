using System.Security;
using System.Text;

namespace xilauncher
{
    [Serializable]
    public struct XiLoaderUserConfig
    {

        #region Fields
        /// <summary>
        /// the username passed to xiloader process
        /// </summary>
        public string Username = "";
        /// <summary>
        /// the password passed to xiloader process (is passed in plaintext and not securely stored)
        /// </summary>
        public SecureString Password = new SecureString();
        /// <summary>
        /// flag that determines whether a new account should be created if possible (not supported by xiloader yet)
        /// </summary>
        public bool CreateAccount = false;
        /// <summary>
        /// the ip or host name of the server passed to xiloader process
        /// </summary>
        public string Server = "127.0.0.1";
        /// <summary>
        /// flag that enables the --hairpin option on the xiloader process for public exposed server access
        /// </summary>
        public bool UseHairPin = false;

        #endregion


        public XiLoaderUserConfig()
        {
        }

        public XiLoaderUserConfig(string userName, string unsafePassword, string server, bool hairpin)
        {
            Username = userName;
            Password = new System.Security.SecureString();
            CreateAccount = false;
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
            sb.Append("--hide ");

            // ToDo: add 'createAccount' as --create to the xi loader arguments assembled here
            return sb.ToString();
        }
    }

}
