using System;
using System.Collections.Generic;
using System.Linq;
using SuperSocket.SocketBase.Command;

namespace SuperSocket.Imap.Server
{
    public abstract class BaseIMAPCommand<TUserKey>: ICommand<ImapServerSession<TUserKey>, ImapRequestInfo>
    {
        /// <summary>
        /// Executes the command.
        /// </summary>
        /// <param name="session">The session.</param><param name="requestInfo">The request info.</param>
        public abstract void ExecuteCommand(ImapServerSession<TUserKey> session, ImapRequestInfo requestInfo);

        /// <summary>
        /// Gets the name.
        /// </summary>
        public abstract string Name
        {
            get;
        }
    }
}
