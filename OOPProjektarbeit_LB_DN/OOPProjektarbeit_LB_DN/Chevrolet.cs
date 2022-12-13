using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjektarbeit_LB_DN
{
  internal class Chevrolet : Carmodel
  {
    //Member variables
    public string _ChevroletType { get; set; }

    //Constructors
    public Chevrolet(string name) : base("Coupé", "brown")
    {
      _ChevroletType = name;
    }

    //Methods
    public override string CarBrand()
    {
      return "Chevrolet";
    }
    public override string CarNationality()
    {
      return "American";
    }

    // override Output
    public override void getCar()
    {
      base.getCar();
      string text2 = $", the car type is {_ChevroletType} and the car brand is {CarBrand()}. Origin: {CarNationality()}";
      Console.Write(text2);
    }
  }
}
