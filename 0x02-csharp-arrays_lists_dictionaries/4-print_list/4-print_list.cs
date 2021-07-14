using System;
using System.Collections.Generic;

// create and print list of ints
// the integers in the list start with 0 and increment
// return new list
class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size == 0)
        {
            Console.WriteLine();
        }

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        List<int>newList = new List<int>();
        for (int i = 0; i < size; i++)
        {
            newList.Add(i);
            Console.Write(i);
            // if (i == size - 1)
        }
        return newList;
    }
}

