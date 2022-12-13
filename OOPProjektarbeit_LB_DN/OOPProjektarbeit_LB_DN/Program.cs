using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjektarbeit_LB_DN
{
  internal class Program
  {
    //Main-Methode
    static void Main(string[] args)
    {
      //Objects
      Audi au1 = new Audi("RSQ8");
      Audi au2 = new Audi();
      BMW bmw1 = new BMW("X6M");
      Mercedes merc1 = new Mercedes("C180 2022");

      Ford Fo1 = new Ford("Mustang Shelby GT500");
      Chevrolet Che1 = new Chevrolet("Camaro SS 1969");

      Fiat Fi1 = new Fiat("500x");;
      Interface n2 = Fi1;
      Fiat Fi2 = new Fiat();

      Carmodel carmodel1 = new Carmodel("SUV", "green");
      Carmodel carmodel2 = new Carmodel("Limosine", "yellow");

      //Array
      List<Carmodel> carmodels = new List<Carmodel>();
      carmodels.Add(au1);
      carmodels.Add(au2);
      carmodels.Add(bmw1);
      carmodels.Add(merc1);
      carmodels.Add(Fo1);
      carmodels.Add(Che1);
      carmodels.Add(Fi1);
      carmodels.Add(Fi2);
      carmodels.Add(carmodel1);
      carmodels.Add(carmodel2);

      //Loop
      foreach (Carmodel a in carmodels)
      {   
        a.getCar();
      }

      //Output
      Console.ReadLine();
    }
  }
}




