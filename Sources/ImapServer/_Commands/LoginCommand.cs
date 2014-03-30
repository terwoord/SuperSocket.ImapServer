using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSocket.Imap.Server
{
    public class LoginCommand<TUserKey>: BaseIMAPCommand<TUserKey>
    {
        /// <summary>
        /// Executes the command.
        /// </summary>
        /// <param name="session">The session.</param><param name="requestInfo">The request info.</param>
        public override void ExecuteCommand(ImapServerSession<TUserKey> session, ImapRequestInfo requestInfo)
        {
            if (requestInfo.Parameters.Length != 2)
            {
                session.SendLine("* BAD Wrong number of arguments");
                return;
            }
            TUserKey userKey;
            if (!session.AppServer.AuthenticationProvider.Authenticate(requestInfo.Parameters[0], requestInfo.Parameters[1], out userKey))
            {
                
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public override string Name
        {
            get
            {
                return "login";
            }
        }
    }
}