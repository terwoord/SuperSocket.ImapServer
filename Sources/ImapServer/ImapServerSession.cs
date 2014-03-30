using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;

namespace SuperSocket.Imap.Server
{
    public class ImapServerSession<TUserKey>: AppSession<ImapServerSession<TUserKey>, ImapRequestInfo>
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
        protected override void HandleUnknownRequest(ImapRequestInfo requestInfo)
        {
            base.HandleUnknownRequest(requestInfo);
            Console.WriteLine("Unknown request");
        }

        /// <summary>
        /// Called when [session started].
        /// </summary>
        protected override void OnSessionStarted()
        {
            base.OnSessionStarted();
            SendLine("* OK TestService ready");
        }

        public new ImapServer<TUserKey> AppServer
        {
            get
            {
                return (ImapServer<TUserKey>)base.AppServer;
            }
        } 

        public void SendLine(string data)
        {
            Send(data);
            Send("\r\n");
        }

        public bool Authenticated
        {
            get;
            set;
        }

        public TUserKey UserKey
        {
            get;
            set;
        }

        public void SendBAD(string message)
        {
            Send("* BAD " + message);
        }

        public void SendLine(ImapRequestInfo request, string data)
        {
            Send("{0} {1}", request.CommandTag, data);
        }
    }
}