﻿using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> newDict = new Dictionary<string, int>();
        foreach (var v in myDict)
        {
            newDict.Add(v.Key, v.Value * 2);
        }
        return newDict;
    }
}