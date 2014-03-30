using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSocket.Imap.Server
{
    public static class StringUtilities
    {
        public static string Fetch(string data, ref int startingPosition, char nextSeparator)
        {
            if (data == null)
            {
                throw new ArgumentNullException("data");
            }
            if (startingPosition >= data.Length)
            {
                return null;
            }

            var oldStartPos = startingPosition;
                
            var nextPos = data.IndexOf(nextSeparator, startingPosition);
            if (nextPos == -1)
            {
                startingPosition = data.Length;
                return data.Substring(oldStartPos);
            }
            startingPosition = nextPos + 1;
            return data.Substring(oldStartPos, nextPos - oldStartPos);
        }
    }
}