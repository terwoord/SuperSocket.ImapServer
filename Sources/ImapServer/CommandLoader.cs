using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.Common;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Config;

namespace SuperSocket.Imap.Server
{
    public class ImapCommandLoader<TUserKey> : CommandLoaderBase<BaseIMAPCommand<TUserKey>>, ICommandLoader<ICommand<ImapServerSession<TUserKey>, ImapRequestInfo>>
    {
        /// <summary>
        /// Initializes the command loader by the root config and appserver instance.
        /// </summary>
        /// <param name="rootConfig">The root config.</param><param name="appServer">The app server.</param>
        /// <returns/>
        public override bool Initialize(IRootConfig rootConfig, IAppServer appServer)
        {
            return true;
        }

        /// <summary>
        /// Tries to load commands.
        /// </summary>
        /// <param name="commands">The commands.</param>
        /// <returns/>
        bool ICommandLoader<ICommand<ImapServerSession<TUserKey>, ImapRequestInfo>>.TryLoadCommands(out IEnumerable<ICommand<ImapServerSession<TUserKey>, ImapRequestInfo>> commands)
        {
            var result = new List<BaseIMAPCommand<TUserKey>>();
            result.Add(new HELPcommand<TUserKey>());
            commands = result;
            return true;
        }

        private EventHandler<CommandUpdateEventArgs<ICommand<ImapServerSession<TUserKey>, ImapRequestInfo>>> mTestUpdated;
        event EventHandler<CommandUpdateEventArgs<ICommand<ImapServerSession<TUserKey>, ImapRequestInfo>>> ICommandLoader<ICommand<ImapServerSession<TUserKey>, ImapRequestInfo>>.Updated
        {
            add
            {
                mTestUpdated += value;
            }
            remove
            {
                mTestUpdated -= value;
            }
        }

        /// <summary>
        /// Tries to load commands.
        /// </summary>
        /// <param name="commands">The commands.</param>
        /// <returns/>
        public override bool TryLoadCommands(out IEnumerable<BaseIMAPCommand<TUserKey>> commands)
        {
            var result = new List<BaseIMAPCommand<TUserKey>>();
            result.Add(new HELPcommand<TUserKey>());
            commands = result;
            return true;
        }
    }
}