using System;
using System.Collections.Generic;

// Returns a new sorted list of all elements present in one or the other list but not both of the given lists
class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        HashSet<int> first = new HashSet<int>(list1);
        HashSet<int> second = new HashSet<int>(list2);
        first.SymmetricExceptWith(second);
        List<int> sorted = new List<int>(first);
        sorted.Sort();
        return sorted;
    }
}

