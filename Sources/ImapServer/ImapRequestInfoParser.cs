using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.SocketBase.Protocol;

namespace SuperSocket.Imap.Server
{
    public class ImapRequestInfoParser: IRequestInfoParser<ImapRequestInfo>
    {
        /// <summary>
        /// Parses the request info from the source string.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns/>
        public ImapRequestInfo ParseRequestInfo(string source)
        {
            var reqInfo = new ImapRequestInfo();
            reqInfo.Parse(source);
            return reqInfo;
        }
    }
}