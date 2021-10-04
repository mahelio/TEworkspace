using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    //IsItTheSame([1, 2, 3]) → false
    //IsItTheSame([1, 2, 3, 1]) → true
    //IsItTheSame([1, 2, 1]) → true
    [TestClass]
    public class SameFirstLastTests
    {
        [TestMethod]
        public void SameFirstLastTest()
        {
            SameFirstLast sameFirstLast = new SameFirstLast();
            Assert.IsFalse(sameFirstLast.IsItTheSame(new[] { 1, 2, 3 }));
            Assert.IsTrue(sameFirstLast.IsItTheSame(new[] { 1, 2, 3, 1 }));
            Assert.IsTrue(sameFirstLast.IsItTheSame(new[] { 1, 2, 1 }));
        }
    }
}
