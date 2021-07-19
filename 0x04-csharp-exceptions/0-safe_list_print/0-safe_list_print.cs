using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int i = 0;
        
        try
        {
            while (i < n)
            {
                Console.WriteLine(myList[n]);
                i++;
            }
        }
        catch (Exception)
        {
            return i;
        }
    return i;
    }
}