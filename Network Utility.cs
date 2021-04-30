using System;
using System.Net.NetworkInformation;

//Charles Alexander
namespace Network_Utility
{
    class Program
    {
        private static string user_input_a = "Ping";
        private static string userinputb = "Trancert";
        private static string userinputc = "Display IP";

        static void Main(string[] args)
        {
            //Welcomes user and becomes main menu
            Console.WriteLine("Welcome! \nWhat do you want to do? Use: \nPing \nTrancert \nDisplay IP");

            //start of funtion
            //if user wants to use ping funtion
            if (user_input_a == Console.ReadLine()) 
            {
                try
                {
                    //Console.WriteLine("A works"); (tset to see if it worked)
                    Ping myPing = new Ping();
                    PingReply reply = myPing.Send("192.168.1.75", 1000);
                    if (reply != null)
                    {
                        Console.WriteLine("Status:" + reply.Status + "\n Time:" + reply.RoundtripTime.ToString() + "\n Address:" + reply.Address);
                    }
                }
                catch
                {
                    Console.WriteLine("Error: You have a timeout issue");
                }
                Console.ReadKey();
            }
            

            //if user wants to use trancert funtion
            if (userinputb == Console.ReadLine())
            {
                //Console.WriteLine("B works");
            }

            //if user wants to display IP address
            if (userinputc == Console.ReadLine())
            {
                //Console.WriteLine("A works"); Test line
                Console.WriteLine("Your IP: \n 192.168.1.75");
            }

            //if user inputs non of the key words
            else
            {
                Console.WriteLine("Incorect Input");
            };
        }
    }
}
