using System;
using System.Text.RegularExpressions;

namespace CheckChars
{
    public class Checker
    {
        public static bool TestString(string text)
        {
            char[] polishChars = { 'ż', 'ź', 'ć', 'ń', 'ó', 'ł', 'ę', 'ą', 'ś' };

            foreach (char polishChar in polishChars)
            {
                if (text.Contains(polishChar))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
