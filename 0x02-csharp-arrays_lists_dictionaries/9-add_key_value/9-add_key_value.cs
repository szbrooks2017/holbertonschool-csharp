using System;
using System.Collections.Generic;

// add a key and value to a dict

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)        {
        myDict[key] = value;
        return myDict;
    }
}
