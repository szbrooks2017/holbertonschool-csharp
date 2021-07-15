using System;
using System.Collections.Generic;

// return a sorted list of common elements in two lists. 
class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> first = new HashSet<int>(list1);
        HashSet<int> second = new HashSet<int>(list2);
        first.IntersectWith(second);
        List<int> sorted = new List<int>(first);
        return sorted;
    }
}