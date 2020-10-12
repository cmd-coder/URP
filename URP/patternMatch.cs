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
        
        public bool matchFName(string fName)
        {
            return Regex.IsMatch(fName, patternFName);
        }

        public bool matchEmail(string email)
        {
            return Regex.IsMatch(email, patternEmail);
        }

        public bool matchMobile(string mobile)
        {
            return Regex.IsMatch(mobile, patternMobile);
        }

        public bool matchPassword(string password)
        {
            return Regex.IsMatch(password, patternPassword);
        }
    }
}
