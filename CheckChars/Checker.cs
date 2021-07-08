using System;
using System.Text.RegularExpressions;

namespace CheckChars
{
    public class Checker
    {
        public static bool TestString(string text)
        {            
            string pattern = "[a-zżźćńółęąś]*";

            Regex rgx = new Regex(pattern);

            foreach (Match match in rgx.Matches(text.ToLower()))
                return true;

            return false;
        }
    }
}
