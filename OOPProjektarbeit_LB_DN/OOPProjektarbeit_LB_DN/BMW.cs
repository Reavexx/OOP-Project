using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjektarbeit_LB_DN
{
  internal class BMW : Carmodel
  {
    //Member Variables
    public string _BMWType { get; set; }

    //Constructors
    public BMW(string name) : base("SUV", "black")
    {
      _BMWType = name;
    }

    //Methods
    public override string CarBrand()
    {
      return "BMW";
    }
    public override string CarNationality()
    {
      return "Germany";
    }

    // override Output
    public override void getCar()
    {
      base.getCar();
      string text2 = $", the car type is {_BMWType} and the car brand is {CarBrand()}. Origin: {CarNationality()}";
      Console.Write(text2);
    }
  }
}
