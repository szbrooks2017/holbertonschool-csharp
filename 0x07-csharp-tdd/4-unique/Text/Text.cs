using System;
using System.Collections.Generic;
using System.Linq;

namespace Text
{
    ///<summary> Return the index of the first non repeating character</summary>
    public class Str
    {
        ///<summary> method that returns a unique character or -1 if none</summary>
        public static int UniqueChar(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                char unique = s[i];
                if (s.IndexOf(unique) == i && s.IndexOf(unique, i + 1) == -1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
