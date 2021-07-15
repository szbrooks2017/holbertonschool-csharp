using System;
using System.Collections.Generic;
// write a method that adds all unique ints in a list
class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> sumNumb = new HashSet<int>(myList);

        int total = 0;
        foreach (int i in sumNumb)
        {
            total += i;
        }
        return total;
    }
}