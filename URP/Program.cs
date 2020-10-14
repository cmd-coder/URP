using System;

namespace URP
{
    public class Program
    {
        string fName, lName, email, mobile, password;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            patternMatch obj = new patternMatch();
            //string fName, lName, email, mobile, password;
            Console.WriteLine("Enter first name");

            Program objProgram = new Program();

            while (true)//Loop to check First Name untill entered correctly
            {
                bool flagFName = objProgram.enterFName();
                if (!flagFName)
                    Console.WriteLine("You have entered wrong first name. Enter again");
                else
                    break;
            }

            Console.WriteLine("Enter last name");

            while (true)//Loop to check Last Name untill entered correctly
            {
                bool flagLName = objProgram.enterLName();
                if (!flagLName)
                    Console.WriteLine("You have entered wrong last name. Enter again");
                else
                    break;
            }

            Console.WriteLine("Enter email");

            while (true)//Loop to check Email untill entered correctly
            {
                bool flagEmail=objProgram.enterEmail();
                if (!flagEmail)
                    Console.WriteLine("You have entered wrong Email Id. Enter again");
                else
                    break;
            }

            Console.WriteLine("Enter mobile number");

            while (true)//Loop to check Mobile Number untill entered correctly
            {
                bool flagMobile = objProgram.enterMobile();
                if (!flagMobile)
                    Console.WriteLine("You have entered wrong mobile number. Enter again");
                else
                    break;
            }

            Console.WriteLine("Enter password");
            
            while (true)//Loop to check Password untill entered correctly
            {
                bool flagPassword = objProgram.enterPassword();
                if (!flagPassword)
                    Console.WriteLine("You have entered wrong password. Enter again");
                else
                    break;
            }
            
        }

        public bool enterFName()//Function to check first name
        {
            patternMatch obj = new patternMatch();
            fName = Console.ReadLine();
            bool flag = false;
            
            try
            {
                bool checkFName = obj.matchFName(fName);
                flag = true;
            }
            catch(CustomException ce)//Catch Exception in case of invalid first name
            {
                Console.WriteLine(ce.Message);
            }
            return flag;
        }

        public bool enterLName()//Function to check last name
        {
            patternMatch obj = new patternMatch();
            lName = Console.ReadLine();
            bool flag = false;

            try
            {
                bool checkFName = obj.matchLName(lName);
                flag = true;
            }
            catch (CustomException ce)//Catch Exception in case of invalid last name
            {
                Console.WriteLine(ce.Message);
            }
            return flag;
        }

        public bool enterEmail()//Function to check email
        {
            patternMatch obj = new patternMatch();
            email = Console.ReadLine();
            bool flag = false;

            try
            {
                bool checkEmail = obj.matchEmail(email);
                flag = true;
            }
            catch (CustomException ce)
            {
                Console.WriteLine(ce.Message);//Catch Exception in case of invalid email
            }
            return flag;
        }

        public bool enterMobile()//Function to check mobile number
        {
            patternMatch obj = new patternMatch();
            mobile = Console.ReadLine();
            bool flag = false;

            try
            {
                bool checkMobile = obj.matchMobile(mobile);
                flag = true;
            }
            catch (CustomException ce)//Catch Exception in case of invalid mobile number
            {
                Console.WriteLine(ce.Message);
            }
            return flag;
        }

        public bool enterPassword()//Function to check password
        {
            patternMatch obj = new patternMatch();
            password = Console.ReadLine();
            bool flag = false;

            try
            {
                bool checkPassword = obj.matchPassword(password);
                flag = true;
            }
            catch (CustomException ce)//Catch Exception in case of invalid password
            {
                Console.WriteLine(ce.Message);
            }
            return flag;
        }

    }
}
