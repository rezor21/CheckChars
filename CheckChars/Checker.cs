using System;

namespace CheckChars
{
    public class Checker
    {
        public static bool TestString(string text)
        {
            bool result = false;

            char[] polishChars = { 'ż', 'ź', 'ć', 'ń', 'ó', 'ł', 'ę', 'ą', 'ś' };

            foreach (char polishChar in polishChars)
            {
                if (text.Contains(polishChar))
                {
                    result = true;
                }
            }

            return result;

        }
    }
}
