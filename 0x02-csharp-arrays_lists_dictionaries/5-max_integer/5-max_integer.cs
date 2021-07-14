using System;
using System.Collections.Generic;

// find biggest integer of a list
// retrun the largest element
// if list is empty print error
class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }
        var max = myList[0];
        foreach(int i in myList)
        {
            if (i > max)
            {
                max = i;
            }
        }
        return max;
    }
}

