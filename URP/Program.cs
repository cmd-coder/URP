﻿using System;

namespace URP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            patternMatch obj = new patternMatch();
            string fName, lName, email;
            Console.WriteLine("Enter first name");

            while (true)
            {
                fName = Console.ReadLine();
                bool checkFName = obj.matchFName(fName);
                if (!checkFName)
                    Console.WriteLine("You have entered wrong first name. Enter again");
                else
                    break;
            }

            Console.WriteLine("Enter last name");

            while (true)
            {
                lName = Console.ReadLine();
                bool checkLName = obj.matchFName(lName);
                if (!checkLName)
                    Console.WriteLine("You have entered wrong last name. Enter again");
                else
                    break;
            }

            Console.WriteLine("Enter email");

            while (true)
            {
                email = Console.ReadLine();
                bool checkEmail = obj.matchEmail(email);
                if (!checkEmail)
                    Console.WriteLine("You have entered wrong email id. Enter again");
                else
                    break;
            }
        }
    }
}
