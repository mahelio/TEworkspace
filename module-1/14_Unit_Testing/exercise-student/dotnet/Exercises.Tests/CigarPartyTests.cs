using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;



namespace Exercises.Tests
{
    [TestClass]
    

    public class CigarPartyTests
    {
        CigarParty cigarParty = new CigarParty();
        [TestMethod]
        public void CigarPartyTest()
        {
            Assert.IsFalse(cigarParty.HaveParty(30, false));
            Assert.IsTrue(cigarParty.HaveParty(50, false));
            Assert.IsTrue(cigarParty.HaveParty(70, true));
        }
    }
}
