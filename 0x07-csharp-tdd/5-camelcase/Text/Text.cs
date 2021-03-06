using System;

namespace Text
{
    ///<summary>Determine how many words are in a string</summary>
    public class Str
    {
        ///<summary>method that returns number of words in s</summary>
        public static int CamelCase(string s)
        {
            int count = 0;

            if (s.Length == 0 || s == null) return 0;
            
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i])) count++;
            }
            return count + 1;
        }
    }
}
