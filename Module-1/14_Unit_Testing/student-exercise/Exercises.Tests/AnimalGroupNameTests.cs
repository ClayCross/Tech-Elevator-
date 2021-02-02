using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercises.Tests
{
    [TestClass]
     public class AnimalGroupNameTests
    {
        [TestMethod]
        public void GiveAnimalName_ReturnHerd()
        {
            AnimalGroupName animal = new AnimalGroupName();

            string herd = animal.GetHerd("rhino");

            Assert.AreEqual("Crash", herd);

        }

        [TestMethod]

        public void CapitalLetters_ReturnHerd()
        {
            AnimalGroupName animal = new AnimalGroupName();

            string herd = animal.GetHerd("RhInO");

            Assert.AreEqual("Crash", herd);


        }

        [TestMethod]
        public void ReturnsUnknown()
        {
            AnimalGroupName animal = new AnimalGroupName();

            string herd = animal.GetHerd("");

            Assert.AreEqual("unknown", herd);




        }

















    }
}
