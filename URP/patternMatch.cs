using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace URP
{
    class patternMatch
    {
        string patternFName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        string patternEmail = "^[a-zA-Z0-9]+([._+-][a-z0-9A-Z]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-A]{2})?$";

        public bool matchFName(string fName)
        {
            return Regex.IsMatch(fName, patternFName);
        }

        public bool matchEmail(string email)
        {
            return Regex.IsMatch(email, patternEmail);
        }
    }
}
