using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.SocketBase.Protocol;

namespace SuperSocket.Imap.Server
{
    public class ImapRequestInfo: IRequestInfo
    {
        public ImapRequestInfo()
        {
        }

        public string Key
        {
            get;
            private set;
        }

        public string CommandTag
        {
            get;
            private set;
        }

        public void Parse(string source)
        {
            var curPos = 0;
            CommandTag = StringUtilities.Fetch(source, ref curPos, ' ');
            if (String.IsNullOrEmpty(CommandTag))
            {
                throw new ProtocolViolationException("No command tag found!");
            }
            Key = StringUtilities.Fetch(source, ref curPos, ' ');
            if (String.IsNullOrEmpty(CommandTag))
            {
                throw new ProtocolViolationException("No key found!");
            }
            var parameters = new List<string>();
            do
            {
                var parm = StringUtilities.Fetch(source, ref curPos, ' ');
                parameters.Add(parm);
            } while (curPos < source.Length);
            Parameters = parameters.ToArray();
        }

        public string[] Parameters
        {
            get;
            private set;
        }


    }
}