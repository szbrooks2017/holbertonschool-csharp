using System;

namespace Text
{
    ///<summary> class that returns the mas int</summary>
    public class Str
    {
        ///<summary> method tthat returns max  number in list or 0 if empty</summary>
        public static bool IsPalindrome(string s)
        {
            int low = 0;
            int high = s.Length - 1;

            while (low < high)
            {
                if (s[low] != s[high])
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
