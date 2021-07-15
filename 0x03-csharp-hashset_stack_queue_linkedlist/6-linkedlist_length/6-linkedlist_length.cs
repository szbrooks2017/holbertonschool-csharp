using System;
using System.Collections.Generic;

// return the number of elements in a Linked List
class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int count = 0;
        foreach(int item in myLList)
        {
            count++;
        }
        return count;
    }
}
