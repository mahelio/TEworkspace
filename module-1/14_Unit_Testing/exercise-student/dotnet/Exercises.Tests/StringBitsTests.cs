using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    //GetBits("Hello") → "Hlo"
    //GetBits("Hi") → "H"
    //GetBits("Heeololeo") → "Hello"
    [TestClass]
    public class StringBitsTests
    {
        [TestMethod]
        public void StringBitsTest()
        {
            StringBits stringBits = new StringBits();
            Assert.AreEqual("Hlo", stringBits.GetBits("Hello"));
            Assert.AreEqual("H", stringBits.GetBits("Hi"));
            Assert.AreEqual("Hello", stringBits.GetBits("Heeololeo"));
        }
    }
}
