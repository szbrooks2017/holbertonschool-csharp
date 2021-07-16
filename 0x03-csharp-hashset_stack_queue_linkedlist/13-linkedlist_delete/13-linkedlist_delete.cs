using System;
using System.Linq;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        try
        {
            myLList.Remove(myLList.ElementAt(index));
        }
        catch{
            return;
        }
    }
}