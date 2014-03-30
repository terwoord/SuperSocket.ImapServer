using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.SocketBase.Protocol;

namespace SuperSocket.Imap.Server
{
    public class ImapRequestInfoBase<TRequestInfo>: StringRequestInfo
        where TRequestInfo : ImapRequestInfoBase<TRequestInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SuperSocket.SocketBase.Protocol.StringRequestInfo"/> class.
        /// </summary>
        /// <param name="key">The key.</param><param name="body">The body.</param><param name="parameters">The parameters.</param>
        public ImapRequestInfoBase(string key, string body, string[] parameters)
            : base(key, body, parameters)
        {
        }
    }
}