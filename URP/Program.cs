using System;

namespace URP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            patternMatch obj = new patternMatch();
            Console.WriteLine("Enter first name");

            while (true)
            {
                string fName = Console.ReadLine();
                bool checkFName = obj.matchFName(fName);
                if (!checkFName)
                    Console.WriteLine("You have entered wrong first name. Enter again");
                else
                    break;
            }

            Console.WriteLine("Enter last name");

            while (true)
            {
                string fName = Console.ReadLine();
                bool checkFName = obj.matchFName(fName);
                if (!checkFName)
                    Console.WriteLine("You have entered wrong last name. Enter again");
                else
                    break;
            }
        }
    }
}
