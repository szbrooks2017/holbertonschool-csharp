using System;
using System.Collections.Generic;

// return number of keys in a dictionary
class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int count = 0;
        foreach (string key in myDict.Keys)
        {
            if (key != null)
            {
                count++;
            }
        }
        return count;
    }
}