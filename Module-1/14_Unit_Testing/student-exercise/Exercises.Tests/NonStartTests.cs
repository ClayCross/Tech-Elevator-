using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTests
    {
        [TestMethod]
        public void FullStrings_ExpectNormalConcatenation()
        {
            NonStart exercises = new NonStart();

            Assert.AreEqual("ellohere", exercises.GetPartialString("Hello", "There"));
        }

       
    }
}

