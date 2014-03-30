using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.SocketBase.Protocol;

namespace SuperSocket.Imap.Server
{
    public class ImapReceiveFilter<TRequestInfo>: TerminatorReceiveFilter<TRequestInfo>
        where TRequestInfo: IRequestInfo
    {
        private static readonly byte[] mTerminator = new byte[]{10};
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SuperSocket.SocketBase.Protocol.TerminatorReceiveFilter`1"/> class.
        /// </summary>
        public ImapReceiveFilter()
            : base(mTerminator)
        {
        }

        /// <summary>
        /// Resolves the specified data to TRequestInfo.
        /// </summary>
        /// <param name="data">The data.</param><param name="offset">The offset.</param><param name="length">The length.</param>
        /// <returns/>
        protected override TRequestInfo ProcessMatchedRequest(byte[] data, int offset, int length)
        {
            throw new NotImplementedException();
        }
    }
}