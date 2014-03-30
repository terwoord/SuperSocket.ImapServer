using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.Imap.Server;

namespace TestApp
{
    public class ImapRequestInfo: ImapRequestInfoBase<ImapRequestInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SuperSocket.SocketBase.Protocol.StringRequestInfo"/> class.
        /// </summary>
        /// <param name="key">The key.</param><param name="body">The body.</param><param name="parameters">The parameters.</param>
        public ImapRequestInfo(string key, string body, string[] parameters)
            : base(key, body, parameters)
        {
        }
    }
}