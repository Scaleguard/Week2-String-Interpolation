using System;

namespace StringInter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. The app asks for the user's first name and stores it in a separate variable
             * 2. The app asks for the user's last name and stores it in a separate variable
             */

            Console.WriteLine("What's your first name?");
            string FirstName;
            string LastName;
            FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            LastName = Console.ReadLine();
            //Console.WriteLine("Hello there, " + FirstName + " " + LastName);
            //string interpolation
            //$ - alt + ctrl + 4 { - alt gr + 7, } - alt gr + 0
            Console.WriteLine($"Hello there, {FirstName} {LastName}. ");





        }
    }
}
