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
            int i;
            for (i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        return -1;
                    }
                }
            }
            return i;
        }
    }
}
