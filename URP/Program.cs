using System;

namespace URP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            patternMatch obj = new patternMatch();
            string fName, lName, email, mobile, password;
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
                    Console.WriteLine("You have entered wrong Email Id. Enter again");
                else
                    break;
            }

            Console.WriteLine("Enter mobile number");

            while (true)
            {
                mobile = Console.ReadLine();
                bool checkMobile = obj.matchMobile(mobile);
                if (!checkMobile)
                    Console.WriteLine("You have entered wrong mobile number. Enter again");
                else
                    break;
            }

            Console.WriteLine("Enter password");

            while (true)
            {
                password = Console.ReadLine();
                bool checkPassword = obj.matchPassword(password);
                if (!checkPassword)
                    Console.WriteLine("You have entered wrong password. Enter again");
                else
                    break;
            }
        }
    }
}
