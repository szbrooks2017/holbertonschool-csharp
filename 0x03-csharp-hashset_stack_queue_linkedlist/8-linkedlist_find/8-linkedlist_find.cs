using System;
using System.Linq;
using System.Collections.Generic;

// return index of occurrence or -1
class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        var count = 0;
        for (var node = myLList.First; node != null; node = node.Next, count++)
        {
            if (value.Equals(node.Value))
                return count;
        }
        return -1;
    }
}
