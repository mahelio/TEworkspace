using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    //GetPartialString("Hello", "There") → "ellohere"
    //GetPartialString("java", "code") → "avaode"
    //GetPartialString("shotl", "java") → "hotlava"
    [TestClass]
    public class NonStartTests
    {
        [TestMethod]
        public void NonStartTest()
        {
            NonStart nonStart = new NonStart();
            Assert.AreEqual("ellohere", nonStart.GetPartialString("Hello", "There"));
            Assert.AreEqual("avaode", nonStart.GetPartialString("java", "code"));
            Assert.AreEqual("hotlava", nonStart.GetPartialString("shotl", "java"));
        }
    }
}
