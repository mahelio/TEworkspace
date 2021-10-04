using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
//GetLucky([0, 2, 4]) → true
//GetLucky([1, 2, 3]) → false
//GetLucky([1, 2, 4]) → false
namespace Exercises.Tests
{
    [TestClass]

    public class Lucky13Tests
    {
        [TestMethod]
        public void Lucky13Test()
        {
            Lucky13 lucky13 = new Lucky13();
            Assert.IsTrue(lucky13.GetLucky(new[] { 0, 2, 4 }));
            Assert.IsFalse(lucky13.GetLucky(new[] { 1, 2, 3 }));
            Assert.IsFalse(lucky13.GetLucky(new[] { 1, 2, 4 }));
        }
    }
}
