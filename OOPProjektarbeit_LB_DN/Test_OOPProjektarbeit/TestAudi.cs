using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPProjektarbeit_LB_DN;
using NUnit.Framework;

namespace TestOOPProjektarbeit_LB_DN
{
    // Test Base
    [TestFixture]
    public class TestAudi
    {   
        [Test]
        public void TestAudiCarBrand()
        {   
            // Test Model

            // arrange
            Audi au1 = new Audi();
            // act
            string result = au1.CarBrand();
            // assert
            Assert.AreEqual("Audi", result);
        }
        [Test]
        public void TestAudiCarNationality()
        {
            // Test Model

            // arrange
            Audi au2 = new Audi();
            // act
            string result = au2.CarNationality();
            // assert
            Assert.AreEqual("Germany", result);
        }
    }
    // Isn't working Purpose not clear
}
