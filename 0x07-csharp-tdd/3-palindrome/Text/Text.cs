using System;
using System.Text.RegularExpressions;

namespace Text
{
    ///<summary> class that returns the mas int</summary>
    public class Str
    {
        ///<summary> method tthat returns max  number in list or 0 if empty</summary>
        public static bool IsPalindrome(string s)
        {
            string s2 = s.ToLower();
            string stripped = Regex.Replace(s2,  @"[^\w\s]", "");
            int low = 0;
            int high = stripped.Length - 1;

            while (low < high)
            {
                if (stripped[low] != stripped[high])
                {
                    return false;
                }
                low++;
                high--;
            }
            return true;
        }
    }
}
