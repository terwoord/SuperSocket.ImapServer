using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.SocketBase.Protocol;

namespace SuperSocket.Imap.Server
{
    public class ImapReceiveFilter: TerminatorReceiveFilter<ImapRequestInfo>
    {
        private static readonly byte[] mTerminator = new byte[]{13,10};
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SuperSocket.SocketBase.Protocol.TerminatorReceiveFilter`1"/> class.
        /// </summary>
        public ImapReceiveFilter()
            : base(mTerminator)
        {
            mRequestInfoParser = new ImapRequestInfoParser();
        }

        private readonly ImapRequestInfoParser mRequestInfoParser;

        /// <summary>
        /// Resolves the specified data to TRequestInfo.
        /// </summary>
        /// <param name="data">The data.</param><param name="offset">The offset.</param><param name="length">The length.</param>
        /// <returns/>
        protected override ImapRequestInfo ProcessMatchedRequest(byte[] data, int offset, int length)
        {
            var source = Encoding.ASCII.GetString(data, offset, length);
            return mRequestInfoParser.ParseRequestInfo(source);
        }
    }
}