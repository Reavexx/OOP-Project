using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjektarbeit_LB_DN
{
  internal class Ford : Carmodel
  {
    //Member variables
    public string _FordType { get; set; }

    //Constructors
    public Ford(string name) : base("Coupé", "brown")
    {
      _FordType = name;
    }

    //Methods
    public override string CarBrand()
    {
      return "Ford";
    }
    public override string CarNationality()
    {
      return "American";
    }

    // override Output
    public override void getCar()
    {
      base.getCar();
      string text2 = $", the car type is {_FordType} and the car brand is {CarBrand()}. Origin: {CarNationality()}";
      Console.Write(text2);
    }
  }
}
