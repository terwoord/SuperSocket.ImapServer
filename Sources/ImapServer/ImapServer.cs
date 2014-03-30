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
    public class ImapServer<TUserKey>: AppServer<ImapServerSession<TUserKey>, ImapRequestInfo>
    {
        public ImapServer(IAuthenticationProvider<TUserKey> authenticationProvider)
            : base(new DefaultReceiveFilterFactory<ImapReceiveFilter, ImapRequestInfo>())
        {
            if (authenticationProvider == null)
            {
                throw new ArgumentNullException("authenticationProvider");
            }
            AuthenticationProvider = authenticationProvider;
        }

        public IAuthenticationProvider<TUserKey> AuthenticationProvider
        {
            get;
            private set;
        } 

        /// <summary>
        /// Setups the command loaders.
        /// </summary>
        /// <param name="commandLoaders">The command loaders.</param>
        /// <returns/>
        protected override bool SetupCommandLoaders(List<ICommandLoader<ICommand<ImapServerSession<TUserKey>, ImapRequestInfo>>> commandLoaders)
        {
            commandLoaders.Add(new ImapCommandLoader<TUserKey>());
            return base.SetupCommandLoaders(commandLoaders);
        }
    }
}