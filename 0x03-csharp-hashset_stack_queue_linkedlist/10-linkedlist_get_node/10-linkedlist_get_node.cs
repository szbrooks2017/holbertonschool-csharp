using System;
using System.Linq;
using System.Collections.Generic;

// return the vaule of the nth node
class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {

        var value = myLList.ElementAt(n);
        if (value != n)
        {
            return value;
        }
        else
        {
            return 0;
        }
    }
}