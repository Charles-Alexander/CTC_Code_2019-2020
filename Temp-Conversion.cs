//Charles Alexander
using System;

namespace Temp_Conversion_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bool for T and F
            bool x = true;

            //variable for user input
            string user_input = null;

            //Variables for temp
            int Fahreheit = 0;
            int Celsius = 0;
            int Kelvin = 0;

            //Starts Program
            Console.WriteLine("Hello! Welcome to Tempature Covertion.");
            while (x == true)
            {
                Console.WriteLine("What do you want to do?\nFahreheit? \nCelsius \nKelvin? \nExit?");
                user_input = Console.ReadLine();

                //Fahreit Funtion
                if (user_input == "Fahreheit")
                {
                    Console.WriteLine("Input the number of degrees:");
                    Fahreheit = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine ($"{Fahreheit} degrees Fahreheit is {((Fahreheit - 32) * 5)/9} degrees Celsius.");
                    Console.WriteLine ($"{Fahreheit} degrees Fahreheit is {(((Fahreheit - 32) * 5) / 9) + 273.15} Kelvin");
                }

                //Celsius Funtion
                else if (user_input == "Celsius")
                {
                    Console.WriteLine("Input the number of degrees:");
                    Celsius = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine ($"{Celsius} degrees Celsius is {((Celsius * 5)/9) + 32} Fahreheit.");
                    Console.WriteLine ($"{Celsius} degrees Celsius is {(Celsius + 273.15)} Kelvin");

                }

                //Kelvin Funtion
                else if (user_input == "Kelvin")
                {
                    Console.WriteLine("Input the number of degrees:");
                    Kelvin = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine ($" {Kelvin} degrees Kelvin is {(Kelvin - (273.15 * 5)) / 9 + 32} Fahreheit ");
                    Console.WriteLine($" {Kelvin} degrees Kelvin is {Kelvin - 273.15} Celsius ");
                }

                else if (user_input == "Exit")
                {
                    System.Environment.Exit(0);
                }

                //If key word is wrong Funtion 
                //later summer practice make code to use upper and lower case
                else
                {
                    Console.WriteLine("Input Error. Try again.");
                }
            }
            
        }
    }
}
