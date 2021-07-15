using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var temp = myDict.Keys.ToList();
        temp.Sort();

        foreach (var k in temp)
        {
            Console.WriteLine("{0}: {1}", k, myDict[k]);
        }
    }
}