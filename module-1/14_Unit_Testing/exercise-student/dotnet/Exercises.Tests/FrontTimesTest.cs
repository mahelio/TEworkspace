using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    //frontTimes("Chocolate", 2) → "ChoCho"
    //frontTimes("Chocolate", 3) → "ChoChoCho"
    //frontTimes("Abc", 3) → "AbcAbcAbc"
    [TestClass]
    public class FrontTimesTest //test each
    {
        FrontTimes frontTimes = new FrontTimes();
        [TestMethod]
        public void FrontRepeat()
        {
            string result = frontTimes.GenerateString("Chocolate", 2);
            Assert.AreEqual("ChoCho", result);
        }
        [TestMethod]
        public void FrontRepeatThree()
        {
            string result = frontTimes.GenerateString("Chocolate", 3);
            Assert.AreEqual("ChoChoCho", result);
        }
        [TestMethod] 
        public void CharsRepeat()
        {
            string result = frontTimes.GenerateString("Abc", 3);
            Assert.AreEqual("AbcAbcAbc", result);
        }
        
    }
}
