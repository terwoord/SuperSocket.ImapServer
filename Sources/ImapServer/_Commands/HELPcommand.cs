using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;

namespace SuperSocket.Imap.Server
{
    public class HELPcommand<TUserKey> : BaseIMAPCommand<TUserKey>
    {
        /// <summary>
        /// Executes the command.
        /// </summary>
        /// <param name="session">The session.</param><param name="requestInfo">The request info.</param>
        public override void ExecuteCommand(ImapServerSession<TUserKey> session, ImapRequestInfo requestInfo)
        {
            session.Send("Nog niet geimplementeerd");
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public override string Name
        {
            get
            {
                return "help";
            }
        }
    }
}