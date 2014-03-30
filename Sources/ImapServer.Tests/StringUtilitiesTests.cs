using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SuperSocket.Imap.Server.Tests
{
    [TestClass]
    public class StringUtilitiesTests
    {
        [TestMethod]
        public void TestFetch()
        {
            AssertPos("Hello, World!", 0, 7, ' ', "Hello,");
            AssertPos("Hello, World!", 7, 13, ' ', "World!");
            AssertPos("Hello, World!", 13, 13, ' ', null);
        }

        private void AssertPos(string data, int originalStartPos, int nextStartPos, char separator, string fetchedData)
        {
            var startPos = originalStartPos;
            Assert.AreEqual(fetchedData, StringUtilities.Fetch(data, ref startPos, separator));
            Assert.AreEqual(nextStartPos, startPos);
        }
    }
}