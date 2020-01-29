using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure_FraleyMichael
{
    class Program
    {
        static void Main(string[] args)
        {
            //main loops through menu and calls method based on choice
            string choice;
            displayMenu();
            choice = Console.ReadLine();
            //loop condition
            // My 6 choices, display room, Weapons, Potions, Items, Mob, Exit
            while (choice != "6")
            {
                switch (choice)
                {
                    case "1":
                        displayRooms();
                        break;
                    case "2":
                        displayWeapons();
                        break;
                    case "3":
                        displayPotions();
                        break;
                    case "4":
                        displayItem();
                        break;
                    case "5":
                        displayMob();
                        break;
                    case "6":
                        Exit();
                        break;
                    default:
                        {
                            Console.WriteLine("Invalid entry. Please reenter choice: ")
                            Console.Clear();
                            displayMenu();
                            break;
                        } //end default
                }//end switch
                //out of the switch but still in loop
                //redisplay the menu because the user has doen one of these items
                Console.Clear();
                DisplayMenu();
                choice = Console.ReadLine();
            }//end while
        }//end main

        staic void displayMenu()
        {
            //Display main menu for the users choices
            Console.WriteLine("Display Rooms");
            Console.WriteLine("Display Weapons");
            Console.WriteLine("Display potion");
            Console.WriteLine("Display Items");
            Console.WriteLine("Display Mob");
            Console.WriteLine("Exit");
            Console.WriteLine();
            Console.WriteLine("Enter Choice: ")
        }


        //My Rooms, Weapons, Potion, Treasures, Items and Mobs
            string[] rooms = new string[] {"Woods", "Cave", "Village Far Away", "Towards the Waterfall" };
            string[] weapons = new string[] { "Sword", "Shuriken", "Dagger", "JuJitsu" };
            string[] potion = new string[] { "Healing", "Mana",};
            string[] treasures = new string[] { "Map", "Wardrobe", "Food"};

            List<string> items = new List<string>() { "HP candy", "Chopstix", "Letter from your father", "Picture of your family" };
            List<string> mobs = new List<string>(){ "Wandering Trader", "Fox", "Pig", "Salmon" };

        }
    }
}
