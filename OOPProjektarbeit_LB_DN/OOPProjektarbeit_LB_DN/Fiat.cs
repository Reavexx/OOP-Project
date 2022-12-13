using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjektarbeit_LB_DN
{
    
  internal class Fiat : Carmodel, Interface
  {
      
    //Member variables
    public string _FiatType { get; set; }

    //Constructors
    public Fiat(string name) : base("Hatchback", "green")
    {
      _FiatType = name;
    }

    public Fiat() : base("SUV", "white")
    {
      _FiatType = "not defined";
    }

    //Methods
    public override string CarBrand()
    {
      return "Fiat";
    }
    public override string CarNationality()
    {
      return "Italy";
    }

    // Interface
    public string Year()
    {
      return "Year: 1990";
    }

    // override Output
    public override void getCar()
    {
      base.getCar();
      string text2 = $", the car type is {_FiatType} and the car brand is {CarBrand()}. Origin: {CarNationality()} {Year()}";
      Console.Write(text2);
    }

  }
}
