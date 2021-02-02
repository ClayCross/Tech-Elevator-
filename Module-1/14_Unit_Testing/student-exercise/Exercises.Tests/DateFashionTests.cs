using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{

    [TestClass]
    public class DateFashionTests
    {
        [TestMethod]

        public void GetATable()
        {
            DateFashion people = new DateFashion();

            Assert.AreEqual(2, people.GetATable(8, 5));
            Assert.AreEqual(2, people.GetATable(3, 9));

        }

        [TestMethod]

        public void DontGetATable()
        {
            DateFashion people = new DateFashion();

            Assert.AreEqual(0, people.GetATable(8, 2));

            Assert.AreEqual(0, people.GetATable(7, 1));

        }

        [TestMethod]

        public void MaybeGetATable()
        {
            DateFashion people = new DateFashion();

            Assert.AreEqual(1, people.GetATable(4, 7));

            Assert.AreEqual(1, people.GetATable(3, 5));
        }
    }
}
