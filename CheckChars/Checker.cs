using System;

namespace CheckChars
{
    public class Checker
    {
        public static bool TestString(string text)
        {
            bool result = false;

            if (text.Contains('ą'))
            {
                result = true;
            }

            return result;
        }
    }
}
