using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
   public class Less20Tests
    {
        [TestMethod]
        public void Less20Test()
        {
            //simple and faster
            Less20 less20 = new Less20();
            Assert.IsTrue(less20.IsLessThanMultipleOf20(18));
            Assert.IsTrue(less20.IsLessThanMultipleOf20(19));
            Assert.IsFalse(less20.IsLessThanMultipleOf20(20));
        }
        
    }
}
