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

        public void WithinTwo_ReturnTrue()
        {
            Less20 num = new Less20();

            Assert.AreEqual(true, num.IsLessThanMultipleOf20(19));
            Assert.AreEqual(true, num.IsLessThanMultipleOf20(38));
            Assert.AreEqual(true, num.IsLessThanMultipleOf20(79));


        }

        [TestMethod]

        public void WithinTwo_ReturnFalse()
        {
            Less20 num = new Less20();

            Assert.AreEqual(false, num.IsLessThanMultipleOf20(15));
            Assert.AreEqual(false, num.IsLessThanMultipleOf20(45));
            Assert.AreEqual(false, num.IsLessThanMultipleOf20(75));


        }



    }
}
