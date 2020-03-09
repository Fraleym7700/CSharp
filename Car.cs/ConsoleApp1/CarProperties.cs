using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class CarProperties
  {
    private int _year;
    private string _make;
    private int _speed;

    public CarProperties(int year, string make, int speed)
    {
      Year = year;
      Make = make;
      Speed = speed;
    }
    public int Year
    {
      get
      {
        return _year;
      }
      set
      {
        _year = value;
      }
    }

       public string Make
    {
      get
      {
        return _make;
      }
      set
      {
        _make = value;
      }
    }
       public int Speed
    {
      get
      {
        return _speed;
      }
      set
      {
        _speed = value;
      }
    }
    //public string Year { get; set; }
    //public string Make { get; set; }
    //public int Speed { get; set; }
    
   

  }
}
