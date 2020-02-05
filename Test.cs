using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
         
            Console.WriteLine("Welcome to my program, Enter an integer to make the choice you would like to make.");
            Console.WriteLine("1. Enter employee's name.");
            Console.WriteLine("2. Enter employee's phone number.");
            Console.WriteLine("3. Enter employee's age.");
            Console.WriteLine("4. Display employees information.");
            Console.WriteLine("5. Display average age of employees.");
            Console.WriteLine("6. Exit");
            
            string userChoice = Console.ReadLine():
            switch (userChoice)
            {
                case 1:
                    List<> Name = EmployeeName();
                    break;
                case 2:
                    List<> PhoneNumber = EmployeePhoneNumber();
                    break;
                case 3:
                    List<> Age = EmployeeAge();
                    break;
                case 4:
                    DisplayEmployeeInformation(name:, phonenumber:, age:);
                    break;
                case 5:
                    AverageAgeofEmployees();
                    break;
                case 6:
                    Console.WriteLine("exiting app....")
                    break;
                default:
                    {
                        exit();
                        break;
                    }
            }

        }
        static List<string> EmployeeName()
        {


            Console.WriteLine("Enter you Employees Name?: ");
            string nameOfEmployee = Console.ReadLine();
            string[] name = new string[] { nameOfEmployee };
            foreach (string x in name) {
                Console.WriteLine(name)
            }
            return name;  
        }

        static List<double> EmployeePhoneNumber()
        {
            Console.WriteLine("Enter your Employees Phone Number?: ");
            string numberOfEmployee = Console.ReadLine();
            List<string> number = new List<string> { numberOfEmployee };
            foreach (double x in number)
            {
                Console.WriteLine(number)
            }
            return Double(number);
        }




        static List<string> EmployeeAge()
        {
            Console.WriteLine("Enter your Employees Age?: ");
            string ageOfEmployee = Console.ReadLine();
            List<string> age = new List<string> { ageOfEmployee };
            foreach (int x in age)
            {
                Console.WriteLine(age)
            }
            return age;
        }


        static void DisplayEmployeeInformation(string name, string phonenumber, string age)
        {
            Console.WriteLine("These are your employee's names" + name);
            Console.WriteLine("These are your employee's phonenumber" + phonenumber);
            Console.WriteLine("These are your employee's age" + age);

        }

        static List<string> AverageAgeofEmployees()
        {
            Console.WriteLine("Enter your Employees Age?: ");
            string nameOfEmployee = Console.ReadLine();
            List<string> age = new List<string> { nameOfEmployee };
            return age;
        }

    }

}   

