using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace URP
{
    class patternMatch
    {
        string patternFName = "^[A-Z]{1}[a-zA-Z]{2,}$";

        public bool matchFName(string fName)
        {
            return Regex.IsMatch(fName, patternFName);
        }
    }
}
