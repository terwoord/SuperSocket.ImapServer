using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSocket.Imap.Server
{
    public interface IAuthenticationProvider<TUserKey>
    {
        bool Authenticate(string name, string password, out TUserKey userKey);
    }
}