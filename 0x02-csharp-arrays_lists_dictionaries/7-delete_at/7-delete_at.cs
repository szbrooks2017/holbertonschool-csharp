using System;
using System.Collections.Generic;

// delete item at location.
// return updated list
// account for index out of range and return unchanged list
class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index >= 0 && index < myList.Count)
        {
            myList.Remove(index);
        }
        else
        {
            Console.WriteLine("Index is out of range");
        }
        return myList;
    }
}

