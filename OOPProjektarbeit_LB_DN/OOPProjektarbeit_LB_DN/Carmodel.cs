using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjektarbeit_LB_DN
{
  public class Carmodel
  {
    //Member variables
    public string _Color { get; set; }
    public string _Stype { get; set; }


    //Constructors

    public Carmodel(string Stype, string Color)
    {
      _Color = Color;
      _Stype = Stype;
    }
    public virtual string CarBrand()
    {
      return "";
    }
    public virtual string CarNationality()
    {
      return "";
    }

    // Virtual Output

    public virtual void getCar()
    {
      string text1 = $"\nThe structure type is {_Stype}, the car color is {_Color}";
      Console.Write(text1);
    }
  }
}
