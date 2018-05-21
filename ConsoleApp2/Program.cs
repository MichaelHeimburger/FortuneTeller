using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FortuneTellerProject
{
    class Program
    {
        static void Main(string[] args)
        {

            //michael heimburger's fortune teller project
            //Added features: quit command to each input, month input can be the name, roygbiv input can be the name, console clears after every input
            //Declaring Used Variables
            string fName;
            string lName;
            string ageInput;
            int age;
            int retAge;
            int month;
            string color;
            int siblings;
            string vehicle = "default";
            string retHome;
            decimal money = 11.11m;


            //User Input
            //first name input and quit command
            Console.WriteLine("Hello user what is your first name?");
            fName = Console.ReadLine();
            Console.Clear();
            if (fName == "quit")
            {
                Console.WriteLine("Nobody likes a quitter, press any button to quit");
                Console.ReadLine();
                return;
            }
            //last name input and quit command
            Console.WriteLine("Alright, what is your last name?");
            lName = Console.ReadLine();
            Console.Clear();
            if (lName == "quit")
            {
                Console.WriteLine("Nobody likes a quitter, press any button to quit");
                Console.ReadLine();
                return;
            }
            //age input and quit commnand
            Console.WriteLine("If you don't mind me asking what is your age?");
            ageInput = Console.ReadLine();
            Console.Clear();
            bool ageBool = int.TryParse(ageInput, out age);
            if ((ageBool == false) && (ageInput == "quit"))
            {
                Console.WriteLine("Nobody Likes a quitter, press any button to quit");
                Console.ReadLine();
                return;
            }
            else if (ageBool == false)
            {
                Console.WriteLine("Numeral inputs only please input your age as a number or I will crash");
                age = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            //  month input either number or written out name and quit command and forced lower case for written
            Console.WriteLine("Please use a numerical value or write the name of the month were you born in.");
            string monthInput = Console.ReadLine();
            Console.Clear();
            bool monthBool = int.TryParse(monthInput, out month);
            if ((monthBool == false) && (monthInput.ToLower() == "quit"))
            {
                Console.WriteLine("Nobody Likes a quitter, press any button to quit");
                Console.ReadLine();
                return;
            }
            else if (monthBool == false)
            {
                monthInput = monthInput.ToLower();
            }

            //siblings input and quit command

            Console.WriteLine("How many siblings do you have?");
            string sibInput = Console.ReadLine();
            Console.Clear();
            bool sibBool = int.TryParse(sibInput, out siblings);

            if ((sibBool == false) && (sibInput.ToLower() == "quit"))
            {
                Console.WriteLine("Nobody Likes a quitter, press any button to quit");
                Console.ReadLine();
                return;
            }

            //color inpuT
            Console.WriteLine("Out of the classic ROYGBIV colors what is your favorite?");
            Console.WriteLine("Or type help for more info.");
            color = Console.ReadLine().ToLower();
            Console.Clear();

            //Color processing
            if (color == "help")
            {
                Console.WriteLine("ROYGBIV colors are referring to the classic colors:Red,Orange,Yellow,Green,Blue,Indigo,Violet. ");
                Console.WriteLine("Please choose one by either typing a ROYGBIV letter, writing out the color name, or type \"quit\" to quit");
                color = Console.ReadLine().ToLower();
                Console.Clear();
            }
            switch (color)
            {
                case "r":
                case "red":
                    vehicle = "nice pair of shoes";
                    break;
                case "o":
                case "orange":
                    vehicle = "jetpack";
                    break;
                case "y":
                case "yellow":
                    vehicle = "sick pair of heelies";
                    break;
                case "g":
                case "green":
                    vehicle = "private jet";
                    break;
                case "b":
                case "blue":
                    vehicle = "mountain bike";
                    break;
                case "i":
                case "indigo":
                    vehicle = "skateboard";
                    break;
                case "v":
                case "violet":
                    vehicle = "purple prius";
                    break;
                case "quit":
                    Console.WriteLine("nobody likes a quitter, press any button to quit.");
                    Console.ReadLine();
                    return;
                    break;
                default:
                    Console.WriteLine("invalid user input");
                    vehicle = "and doesnt understand how to follow simple isntructions";
                    break;
            }

            // age processing
            int evenOdd = age % 2;
            if (evenOdd == 1)
            { 
                retAge = 70 - age;
            }
            else
            {
                retAge = 90 - age;
            }

            // sibling processing

            if (siblings >= 4)
            {
                retHome = "Hawaii";
            }
            else if (siblings == 3)
            {
                retHome = "Alaska";
            }
            else if (siblings == 2)
            {
                retHome = "an exotic country";
            }
            else if (siblings == 1)
            {
                retHome = "New York city";
            }
            else if (siblings == 0)
            {
                retHome = "your dream location";
            }
            else
            {
                retHome = "your hometown now";
            }

            // birth month/money processing

            if (((month >= 1) && (month <= 4)) || (monthInput == "january") || (monthInput == "february") || (monthInput == "march") || (monthInput == "april"))
            {
                money = 20000.00m;
            }
            else if (((month >= 5) && (month <= 10)) || (monthInput == "april") || (monthInput == "june") || (monthInput == "july") || (monthInput == "august") || (monthInput == "may"))
            {
                money = 50000.00m;
            }
            else if (((month >= 9) && (month <= 12)) || (monthInput == "september") || (monthInput == "october") || (monthInput == "november") || (monthInput == "december"))
            {
                money = 99999.00m;
            }
            else
            {
                money = 0.00m;
            }
            //End result

            Console.WriteLine("{0} {1} will retire in {2} years with {3} in the bank, a vacation home in {4}, and a {5}", fName, lName, retAge, money, retHome, vehicle);
            Console.ReadLine();

        }
    }
}
