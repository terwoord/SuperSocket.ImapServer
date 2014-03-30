using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.SocketBase.Protocol;

namespace SuperSocket.Imap.Server
{
    public class ImapRequestInfoParser<TRequestInfo>: IRequestInfoParser<TRequestInfo>
        where TRequestInfo : ImapRequestInfoBase<TRequestInfo>, new()
    {
        /// <summary>
        /// Parses the request info from the source string.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns/>
        public TRequestInfo ParseRequestInfo(string source)
        {
            return new TRequestInfo();
        }
    }
}