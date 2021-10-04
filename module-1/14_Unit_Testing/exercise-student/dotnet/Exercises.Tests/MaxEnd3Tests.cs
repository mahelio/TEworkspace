using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
//MakeArray([1, 2, 3]) → [3, 3, 3]
//MakeArray([11, 5, 9]) → [11, 11, 11]
//MakeArray([2, 11, 3]) → [3, 3, 3]
namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Tests
    {
        [TestMethod]
        public void MaxEnd3Test()
        {
            MaxEnd3 maxEnd3 = new MaxEnd3();
            CollectionAssert.AreEqual(new[] { 3, 3, 3 }, maxEnd3.MakeArray(new[] { 1, 2, 3 }));
            CollectionAssert.AreEqual(new[] { 11, 11, 11 }, maxEnd3.MakeArray(new[] { 11, 5, 9 }));
            CollectionAssert.AreEqual(new[] { 3, 3, 3 }, maxEnd3.MakeArray(new[] { 2, 11, 3 }));
        }
    }
}
