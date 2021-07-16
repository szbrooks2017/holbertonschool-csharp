using System;
using System.Linq;
using System.Collections.Generic;

// return index of occurrence or -1
class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int i = myLList.TakeWhile(n => n != value).Count();
        return i;
    }
}
