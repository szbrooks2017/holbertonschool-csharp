using System;
using System.Linq;
using System.Collections.Generic;

// insert new node in the correct position.
// get the head?
// when head == nth insert before?

class LList

{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> head = myLList.First;
        LinkedListNode<int> nnode = new LinkedListNode<int>(n);

        if (head == null)
        {
            myLList.AddFirst(nnode);
            return nnode;
        }

        if (head.Value > n)
        {
            myLList.AddBefore(head, nnode);
            return nnode;
        }
    }
}