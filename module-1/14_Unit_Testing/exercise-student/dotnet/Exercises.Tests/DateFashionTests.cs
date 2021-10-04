using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    
    public class DateFashionTests //Class isnt refernced?
    {
        DateFashion dateFashion = new DateFashion();
        [TestMethod]
        public void WeAreStylish()
        {
            int result = dateFashion.GetATable(5, 10);
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void MaybeStylish()
        {
            int result = dateFashion.GetATable(5, 5);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void NotStylish()
        {
            int result = dateFashion.GetATable(2, 5);
            Assert.AreEqual(0, result);
        }
       
        
    }
}
