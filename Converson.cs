//Charles Alexander
using System;

namespace ConversonV3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Volume Variables
            int Length = 0;
            int Height = 0;
            int Width = 0;

            //Standard to Metric
            double Inch = 0;
            double Foot = 0;
            double Yard = 0;
            double Mile = 0;

            //Metric to Standard
            double Millimeter = 0;
            double Centimeter = 0;
            double Meter = 0;
            double Kilometer = 0;

            //Input Variables
            string userinput1 = null;
            string userinput2 = null;
            string userinput3 = null;

            //intro and main menu
            Console.WriteLine("Hello, What do you want to to do" +
                ":\n Calculate Volume\n Convert Standard to Metric\n Convert Metic to Standard? ");

            userinput1 = Console.ReadLine();

            //volume code
            if (userinput1 == "Calculate Volume")
            {
                //Inputs and refresh variables
                Console.WriteLine("Input Length");
                Length = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input Height");
                Height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input Width");
                Width = Convert.ToInt32(Console.ReadLine());

                //Multiply L,H,W and out put it
                int output1 = Length * Height * Width;
                Console.WriteLine("Here is your output:" + output1);

            }
            
            //Standard to Metric
            else if (userinput1 == "Convert Standard to Metric")
            {
                Console.WriteLine("What do you need to be converted?" +
                    ":\n Inch to Centimeter?\n Foot to Centimeter?\n Yard to Meter?\n Mile to Kilometer?");
                userinput2 = Console.ReadLine();

                if (userinput2 == "Inch to Centimeter")
                {
                    Console.WriteLine("Input Inch");
                    Inch = Convert.ToInt32(Console.ReadLine());
                    double output2 = Inch * 2.54;
                    Console.WriteLine("Output:" + output2);
                }

                else if (userinput2 == "Foot to Centimeter")
                {
                    Console.WriteLine("Input Foot");
                    Foot = Convert.ToInt32(Console.ReadLine());
                    double output3 = Foot * 30.48;
                    Console.WriteLine("Output:" + output3);
                }

                else if (userinput2 == "Yard to Meter")
                {
                    Console.WriteLine("Input Yard");
                    Yard = Convert.ToInt32(Console.ReadLine());
                    double output4 = Yard * .914;
                    Console.WriteLine("Output:" + output4);
                }

                else if (userinput2 == "Mile to Kilometer")
                {
                    Console.WriteLine("Input Mile");
                    Mile = Convert.ToInt32(Console.ReadLine());
                    double output5 = Mile * 1.609;
                    Console.WriteLine("Output:" + output5);
                }

                else
                {
                    Console.WriteLine("I don't understand");
                }
            }

            //Metric to Standard
            else if (userinput1 == "Convert Metric to Standard")
            {
                Console.WriteLine("What do you need to be converted?" +
                    ":\n Milimeter to Inch?\n Centimeter to Inch?\n Meter to Yard?\n Kilometer to Mile?");
                userinput3 = Console.ReadLine();

                if (userinput3 == "Milimeter to Inch")
                {
                    Console.WriteLine("Input Milimeter");
                    Millimeter = Convert.ToInt32(Console.ReadLine());
                    double output6 = Millimeter * .039;
                    Console.WriteLine("Output:" + output6);
                }

                else if (userinput3 == "Centimeter to Inch")
                {
                    Console.WriteLine("Input Centilimeter");
                    Centimeter = Convert.ToInt32(Console.ReadLine());
                    double output7 = Centimeter * .394;
                    Console.WriteLine("Output:" + output7);
                }

                else if (userinput3 == "Meter to Yard")
                {
                    Console.WriteLine("Input Meter");
                    Meter = Convert.ToInt32(Console.ReadLine());
                    double output8 = Meter * 1.094;
                    Console.WriteLine("Output:" + output8);
                }

                else if (userinput3 == "Kilometer to Mile")
                {
                    Console.WriteLine("Input Kilimeter");
                    Kilometer = Convert.ToInt32(Console.ReadLine());
                    double output9 = Kilometer * .621;
                    Console.WriteLine("Output:" + output9);
                }

                else
                {
                    Console.WriteLine("I don't understand");
                }
            }

            else
            {
                Console.WriteLine("Error! I don't understand the input.");
            }
        }
    }
}
