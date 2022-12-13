using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OOPProjektarbeit_LB_DN;

namespace Test_OOPProjektarbeit
{
  // Test Base
  [TestFixture]
  public class Test_Carmodel
  {
    //Test Cases Expected Values
    [TestCase("SUV", "Blue", ExpectedResult = "Audi")]
    [TestCase("SUV", "Black", ExpectedResult = "BMW")]
    [TestCase("Coupé", "Brown", ExpectedResult = "Chevrolet")]
    [TestCase("Hatchback", "Green", ExpectedResult = "Fiat")]

    public int Test_CarModel(string Stype, string Color)
    { 
      // Testing Model

      //  arrange
      Carmodel cm = new Carmodel();
      //  act
      string result = cm.CarBrand();
      //  assert
      return result;
    }
  }

  // Isn't working Purpose not clear
}

