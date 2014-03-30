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
    public class ImapServerBase<TSession, TRequestInfo>: AppServer<TSession, TRequestInfo>
        where TSession: ImapServerSessionBase<TSession, TRequestInfo>, new()
        where TRequestInfo: ImapRequestInfoBase<TRequestInfo>
    {
        public ImapServerBase():base(new DefaultReceiveFilterFactory<ImapReceiveFilter<TRequestInfo>, TRequestInfo>())
        {
        }

        /// <summary>
        /// Setups the command loaders.
        /// </summary>
        /// <param name="commandLoaders">The command loaders.</param>
        /// <returns/>
        protected override bool SetupCommandLoaders(List<ICommandLoader<ICommand<TSession, TRequestInfo>>> commandLoaders)
        {
            commandLoaders.Add(new ImapCommandLoader<TSession, TRequestInfo>());
            return base.SetupCommandLoaders(commandLoaders);
        }
    }
}