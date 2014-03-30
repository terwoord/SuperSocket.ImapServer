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
    public class HELPcommand<TSession, TRequestInfo> : BaseIMAPCommand<TSession, TRequestInfo>
        where TSession: ImapServerSessionBase<TSession, TRequestInfo>, new()
        where TRequestInfo: ImapRequestInfoBase<TRequestInfo>
    {
        /// <summary>
        /// Executes the command.
        /// </summary>
        /// <param name="session">The session.</param><param name="requestInfo">The request info.</param>
        public override void ExecuteCommand(TSession session, TRequestInfo requestInfo)
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