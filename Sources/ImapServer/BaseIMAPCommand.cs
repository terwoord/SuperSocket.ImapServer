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
    public abstract class BaseIMAPCommand<TSession, TRequestInfo>: ICommand<TSession, TRequestInfo>
        where TRequestInfo: ImapRequestInfoBase<TRequestInfo>
        where TSession: ImapServerSessionBase<TSession, TRequestInfo>, new()
    {
        /// <summary>
        /// Executes the command.
        /// </summary>
        /// <param name="session">The session.</param><param name="requestInfo">The request info.</param>
        public abstract void ExecuteCommand(TSession session, TRequestInfo requestInfo);

        /// <summary>
        /// Gets the name.
        /// </summary>
        public abstract string Name
        {
            get;
        }
    }
}
