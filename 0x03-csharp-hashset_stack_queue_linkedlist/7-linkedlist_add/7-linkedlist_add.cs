using System;
using System.Collections.Generic;


class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> nnode = myLList.AddFirst(n);
        return nnode;
    }
}
