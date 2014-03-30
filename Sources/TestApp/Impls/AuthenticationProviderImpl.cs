using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.Imap.Server;

namespace TestApp.Impls
{
    public class AuthenticationProviderImpl: IAuthenticationProvider<string>
    {
        public bool Authenticate(string name, string password, out string userKey)
        {
            if (name == "matthijs" && password == "test")
            {
                userKey = "matthijs";
                return true;
            }
            userKey = null; 
            return false;
        }
    }
}