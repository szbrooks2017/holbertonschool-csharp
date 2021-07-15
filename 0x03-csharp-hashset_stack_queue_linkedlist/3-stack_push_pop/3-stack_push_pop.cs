using System;
using System.Collections.Generic;

// create a stack
// print number of items in aStack with proper format
// print items on top of aStack without removing with proper format
// print aStack if it contains a given item search
// if aStack contains the givien item search, remove all items up to including search
// add newItem to aStack
// return aStack
class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        if (aStack.Count == 0)
        {

            Console.WriteLine("Stack is empty");
        }

        // count of items in stack
        int count = aStack.Count;
        Console.WriteLine("Number of items: {0}", count);

        // top item
        string topItem = aStack.Peek();
        Console.WriteLine("Top item: {0}", topItem);

        // if it contains search
        Console.WriteLine("Stack contains \"{0}\": {1}", search, aStack.Contains(search));

        while (aStack.Contains(search) == true)
        {
            aStack.Pop();
        }

        aStack.Push(newItem);
        return aStack;
    }
}