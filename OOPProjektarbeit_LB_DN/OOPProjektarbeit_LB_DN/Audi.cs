using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjektarbeit_LB_DN
{
  public class Audi : Carmodel
  {
    //Member variables
    public string _AudiType { get; set; }

    //Constructors
    public Audi(string name) : base("SUV", "Blue")
    {
      _AudiType = name;
    }

    public Audi() : base("Combi", "red")
    {
      _AudiType = "not defined";
    }

    //Methods
    public override string CarBrand()
    {
      return "Audi";
    }
    public override string CarNationality()
    {
      return "Germany";
    }

    // override Output
    public override void getCar()
    {
      base.getCar();
      string text2 = $", the car type is {_AudiType} and the car brand is {CarBrand()}. Origin: {CarNationality()}";
      Console.Write(text2);
    }

  }
}
