using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class StandardMessages
  {
    public static string CarMenu()
    {
      return "1) Create car\n2) Accelerate\n3) Brake\n4) Exit ";

    }
    public static int CreateCarYear()
    {
      Console.WriteLine("What year is your car?");
      int carYear = Convert.ToInt32(Console.ReadLine());
      return carYear;

    }
    public static string CreateCarMake()
    {
      Console.WriteLine("What Make is your car?");
      string carMake = Console.ReadLine();
      return carMake;

    }
    public static int CreateCarSpeed()
    {
      Console.WriteLine("What year is your car?");
      int carSpeed = Convert.ToInt32(Console.ReadLine());
      return carSpeed;

    }
    
   
  }
}
