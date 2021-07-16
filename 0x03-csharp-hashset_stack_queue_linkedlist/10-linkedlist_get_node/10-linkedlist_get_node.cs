using System;
using System.Linq;
using System.Collections.Generic;

// return the vaule of the nth node
class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (myLList.Count == 0 || n < 0 || n > myLList.Count)
        {
            return 0;
        }
        return myLList.ElementAt(n);
    }
}