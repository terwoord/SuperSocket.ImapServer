using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;

namespace SuperSocket.Imap.Server
{
    public class ImapServerSessionBase<TAppSession, TRequestInfo> : AppSession<TAppSession, TRequestInfo>
        where TAppSession: ImapServerSessionBase<TAppSession, TRequestInfo>, new()
        where TRequestInfo: class, IRequestInfo
    {
        /// <summary>
        /// Handles the exceptional error, it only handles application error.
        /// </summary>
        /// <param name="e">The exception.</param>
        protected override void HandleException(Exception e)
        {
            base.HandleException(e);
            Console.WriteLine("Error: {0}", e.ToString());
        }

        /// <summary>
        /// Handles the unknown request.
        /// </summary>
        /// <param name="requestInfo">The request info.</param>
        protected override void HandleUnknownRequest(TRequestInfo requestInfo)
        {
            base.HandleUnknownRequest(requestInfo);
            Console.WriteLine("Unknown request");
        }
    }
}