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
            // if it contains search
            if (aStack.Contains(search))
            {
                Console.WriteLine("Stack contains \"{0}\": True", search);
            }
            else
            {
                Console.WriteLine("Stack contains \"{0}\": False", search);
            }
            Console.WriteLine("Stack is empty");
        }

        // count of items in stack
        int count = aStack.Count;
        Console.WriteLine("Number of items: {0}", count);

        // top item
        string topItem = aStack.Peek();
        Console.WriteLine("Top item: {0}", topItem);

        // if it contains search
        if (aStack.Contains(search))
        {
            Console.WriteLine("Stack contains \"{0}\": True", search);
        }
        else
        {
            Console.WriteLine("Stack contains \"{0}\": False", search);
        }

        while (aStack.Contains(search) == true)
        {
            aStack.Pop();
        }

        aStack.Push(newItem);
        return aStack;
    }
}