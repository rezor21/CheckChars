using System;

namespace CheckChars
{
    public class Checker
    {
        public static bool TestString(string text)
        {
            bool result = false;
            
            foreach(char myChar in text)
            {
                if(myChar == 'ą')
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
