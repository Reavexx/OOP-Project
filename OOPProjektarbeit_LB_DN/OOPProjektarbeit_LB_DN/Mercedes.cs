using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjektarbeit_LB_DN
{
  internal class Mercedes : Carmodel
  {
    //Member variables
    public string _MercedesType { get; set; }

    //Constructors
    public Mercedes(string name) : base("Limosine", "color not defined")
    {
      _MercedesType = name;
    }

    //Methods
    public override string CarBrand()
    {
      return "Mercedes";
    }
    public override string CarNationality()
    {
      return "Germany";
    }

    // override Output
    public override void getCar()
    {
      base.getCar();
      string text2 = $", the car type is {_MercedesType} and the car brand is {CarBrand()}. Origin: {CarNationality()}";
      Console.Write(text2);
    }
  }
}
