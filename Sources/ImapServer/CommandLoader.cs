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
    public class ImapCommandLoader<TSession, TRequestInfo>: CommandLoaderBase<BaseIMAPCommand<TSession, TRequestInfo>>, ICommandLoader<ICommand<TSession, TRequestInfo>>
        where TSession: ImapServerSessionBase<TSession, TRequestInfo>, new()
        where TRequestInfo: ImapRequestInfoBase<TRequestInfo>
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
        bool ICommandLoader<ICommand<TSession, TRequestInfo>>.TryLoadCommands(out IEnumerable<ICommand<TSession, TRequestInfo>> commands)
        {
            var result = new List<BaseIMAPCommand<TSession, TRequestInfo>>();
            result.Add(new HELPcommand<TSession, TRequestInfo>());
            commands = result;
            return true;
        }

        private EventHandler<CommandUpdateEventArgs<ICommand<TSession, TRequestInfo>>> mTestUpdated;
        event EventHandler<CommandUpdateEventArgs<ICommand<TSession, TRequestInfo>>> ICommandLoader<ICommand<TSession, TRequestInfo>>.Updated
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
        public override bool TryLoadCommands(out IEnumerable<BaseIMAPCommand<TSession, TRequestInfo>> commands)
        {
            var result = new List<BaseIMAPCommand<TSession, TRequestInfo>>();
            result.Add(new HELPcommand<TSession, TRequestInfo>());
            commands = result;
            return true;
        }
    }
}