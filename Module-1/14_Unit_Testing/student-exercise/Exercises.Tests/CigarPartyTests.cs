using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTests
    {
        [TestMethod]

        public void WeekendPartyParty()
        {
            CigarParty party = new CigarParty();

            Assert.AreEqual(true, party.HaveParty(40, true));

            Assert.AreEqual(true, party.HaveParty(60, true));

            Assert.AreEqual(false, party.HaveParty(28, true));

            Assert.AreEqual(true, party.HaveParty(65, true));

        }
        [TestMethod]
        public void WeekdayPartyParty()
        {
            CigarParty party = new CigarParty();

            Assert.AreEqual(true, party.HaveParty(40, false));

            Assert.AreEqual(true, party.HaveParty(60, false));

            Assert.AreEqual(false, party.HaveParty(67, false));

            Assert.AreEqual(false, party.HaveParty(35, false));



        }







    }
}
