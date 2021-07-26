using System;

namespace Text
{
    ///<summary> class that returns the mas int</summary>
    public class Str
    {
        ///<summary> method tthat returns max  number in list or 0 if empty</summary>
        public static bool IsPalindrome(string s)
        {
            string s2 = s.ToLower();
            int low = 0;
            int high = s2.Length - 1;

            while (low < high)
            {
                if (s2[low] != s2[high])
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
