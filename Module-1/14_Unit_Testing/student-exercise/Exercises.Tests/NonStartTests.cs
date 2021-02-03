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
            NonStart words = new NonStart();

            Assert.AreEqual("ellohere", words.GetPartialString("Hello", "There"));
        }

       
    }
}

