using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Program asks for the users first- and lastname
             * 2. Program asks for the users year of birth
             * 3. Program greets the user by ther name and displays their age.
             NB! To display the result use one WrtieLine only!
             */
            Console.WriteLine("What is your first name?");
            string FirstName;
            string LastName;
            FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            LastName = Console.ReadLine();

            Console.WriteLine("What year were you born in?");
            string UserInput;
            UserInput = Console.ReadLine();
            int YearOfBirth;
            YearOfBirth = Int32.Parse(UserInput);
            int Age = 2020 - YearOfBirth;

            Console.WriteLine($"Hello there, {FirstName} {LastName}, you're also {Age} years old.  ");




        }
    }
}
