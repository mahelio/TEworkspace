using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests //test works!
{
    [TestClass]
    public class AnimalGroupNamesTest
    {
        [TestMethod]
        
       
        public void AnimalGroupNameTest()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();
            Assert.AreEqual("Tower", animalGroupName.GetHerd("giraffe"));
            Assert.AreEqual("unknown", animalGroupName.GetHerd(""));
            Assert.AreEqual("unknown", animalGroupName.GetHerd("walrus"));
            Assert.AreEqual("Crash", animalGroupName.GetHerd("Rhino"));
            Assert.AreEqual("Crash", animalGroupName.GetHerd("rhino"));
            Assert.AreEqual("unknown", animalGroupName.GetHerd("elephants"));

        }
    }
}
