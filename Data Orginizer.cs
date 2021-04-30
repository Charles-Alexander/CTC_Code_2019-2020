using System;
using System.IO;
//Charles Alexander
namespace Output_CharlesAlexander.txt
{
    class Program
    {
        static void Main(string[] args)
        {
            //declard variable
            string[] people;

            //varriable with people
            //0-15
            //Lastname - Firstname
            people = new string[15] {
                "Sipowitz Gary",
                "Jones Baldwin",
                "Medavoy Greg",
                "Irvin John",
                "Ortiz Rita",
                "Bale Thomas",
                "Murphy Laura",
                "Angelotti Al",
                "Heilbrenner Robert",
                "Slovak Joe",
                "Quinn Ray",
                "Greenhouse Basil",
                "St John Dale",
                "Heilbrenner Felicia",
                "Nikada Akira"
            };

            //alerts user that names are last to first
            Console.WriteLine("Names listed by last to first name");

            //orders names alphabeical order
            Array.Sort(people);
            foreach (string i in people)
            {
                Console.WriteLine(i);
            }

            //tried to write to text fie. Needs more research and practice
            //string path = @"D:\Text_File.txt";

            //using (StreamWriter sw = File.CreateText(path));
        }
    }
}