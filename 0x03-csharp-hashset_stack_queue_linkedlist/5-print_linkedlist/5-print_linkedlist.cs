using System;
using System.Collections.Generic;

// create and print a linked list of integers.
class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> newList = new LinkedList<int>();

        if (size == 0)
        {
            return newList;
        }

        int i = 0;

        while (i < size)
        {
            newList.AddFirst(i);
            System.Console.WriteLine(i);
            i++;
        }
        return newList;
    }
}
