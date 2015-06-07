using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISO3166.Tests
{
    [TestClass]
    public class FindTests
    {
        [TestMethod]
        public void FindBy2Code_ExistingLowercase_ReturnsMatch()
        {
            var country = Country.FindBy2Code("gb");
            Assert.IsNotNull(country);
            Assert.AreEqual("GB", country.TwoLetterCode);
        }

        [TestMethod]
        public void FindBy2Code_ExistingUppercase_ReturnsMatch()
        {
            var country = Country.FindBy2Code("US");
            Assert.IsNotNull(country);
            Assert.AreEqual("US", country.TwoLetterCode);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FindBy2Code_Blank_Throws()
        {
            Country.FindBy2Code(null);
        }

        [TestMethod]
        public void FindBy2Code_Nonexisting_ReturnsNull()
        {
            var country = Country.FindBy2Code("zz");
            Assert.IsNull(country);
        }

        [TestMethod]
        public void FindBy3Code_ExistingLowercase_ReturnsMatch()
        {
            var country = Country.FindBy3Code("uKr");
            Assert.IsNotNull(country);
            Assert.AreEqual("UKR", country.ThreeLetterCode);
        }

        [TestMethod]
        public void FindBy3Code_ExistingUppercase_ReturnsMatch()
        {
            var country = Country.FindBy3Code("SWE");
            Assert.IsNotNull(country);
            Assert.AreEqual("SWE", country.ThreeLetterCode);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FindBy3Code_Blank_Throws()
        {
            Country.FindBy3Code(null);
        }

        [TestMethod]
        public void FindBy3Code_Nonexisting_ReturnsNull()
        {
            var country = Country.FindBy3Code("zzz");
            Assert.IsNull(country);
        }
    }
}
