using System;
using System.Collections.Generic;

// finds all multiples of 2 in a list
// returns a new list true or false, 
class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool>tfList = new List<bool>();
        foreach (int i in myList)
        {
            if ((i % 2) == 0)
            {
                tfList.Add(true);
            }
            else
            {
                tfList.Add(false);
            }
        }
        return tfList;
    }
}