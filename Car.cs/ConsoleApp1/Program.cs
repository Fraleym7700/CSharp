using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args) 
    {
      
      bool looper = false;
      do
      {
        Console.WriteLine(StandardMessages.CarMenu());
        string input = Console.ReadLine();
        switch (input)
        {
          case "1":

            int carYear1 = StandardMessages.CreateCarYear();
            string carMake1 = StandardMessages.CreateCarMake();
            int carSpeed1 = StandardMessages.CreateCarSpeed();
           CarProperties car = new CarProperties(carYear1, carMake1, carSpeed1);
            break;
          case "2":
            //int acc = car.Speed += 5;
            break;
          case "3":
            //acc = car.Speed -= 5;
            break;
          default:
            Console.WriteLine("Looking forward to the Weekend.");
            break;
        }
      }
      while (looper == false);

        // CarProperties car1 = new CarProperties(carYear, "Hyundai", 180);
        //CarProperties car2 = new CarProperties(2001, "Ford", 145);
        //Console.WriteLine(car1.Year);
        //Console.WriteLine(car1);
        //Console.ReadLine();
    }
   }
  }


