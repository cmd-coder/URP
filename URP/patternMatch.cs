using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace URP
{
    public class patternMatch
    {
        string patternFName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        string patternEmail = "^[a-zA-Z0-9]+([._+-][a-z0-9A-Z]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-A]{2})?$";
        string patternMobile = "^[1-9]{1}[0-9]{0,2}[ ][1-9]{1}[0-9]{9}$";
        string patternPassword = "((?=.*[A-Z])(?=.*[0-9])(?=^[a-zA-Z0-9]*[!@#$%^&*-+_][a-zA-Z0-9]*$)).{8,}";
        
        public bool matchFName(string fName)//Match first name and throw an exception in case of mismatch
        {
            bool flag= Regex.IsMatch(fName, patternFName);
            if (flag)
                return flag;
            else
                throw new CustomException(CustomException.ExceptionType.INVALID_ENTRY, "Invalid First Name");
        }

        public bool matchLName(string fName)//Match last name and throw an exception in case of mismatch
        {
            bool flag = Regex.IsMatch(fName, patternFName);
            if (flag)
                return flag;
            else
                throw new CustomException(CustomException.ExceptionType.INVALID_ENTRY, "Invalid Last Name");
        }

        public bool matchEmail(string email)//Match email and throw an exception in case of mismatch
        {
            bool flag= Regex.IsMatch(email, patternEmail);
            if (flag)
                return flag;
            else
                throw new CustomException(CustomException.ExceptionType.INVALID_ENTRY, "Invalid Email");
        }

        public bool matchMobile(string mobile)//Match mobile number and throw an exception in case of mismatch
        {
            bool flag= Regex.IsMatch(mobile, patternMobile);
            if (flag)
                return flag;
            else
                throw new CustomException(CustomException.ExceptionType.INVALID_ENTRY, "Invalid Mobile Number");
        }

        public bool matchPassword(string password)//Match password and throw an exception in case of mismatch
        {
            bool flag= Regex.IsMatch(password, patternPassword);
            if (flag)
                return flag;
            else
                throw new CustomException(CustomException.ExceptionType.INVALID_ENTRY, "Invalid Password");
        }
    }
}
