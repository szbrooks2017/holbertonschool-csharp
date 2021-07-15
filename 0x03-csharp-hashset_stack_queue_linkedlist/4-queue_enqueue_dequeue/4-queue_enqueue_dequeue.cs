using System;
using System.Collections.Generic;

// create a Queue
// print number of items in aQueue with proper format
// print items on top of aQueue without removing with proper format
// print aQueue if it contains a given item search
// if aQueue contains the givien item search, remove all items up to including search
// add newItem to aQueue
// return aQueue
class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        // count of items in Queue
        int count = aQueue.Count;
        Console.WriteLine("Number of items: {0}", count);

        if (aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            // top item
            string topItem = aQueue.Peek();
            Console.WriteLine("First item: {0}", topItem);
        }

        // if it contains search
        Console.WriteLine("Queue contains \"{0}\": {1}", search, aQueue.Contains(search));

        while (aQueue.Contains(search) == true)
        {
            aQueue.Dequeue();
        }

        aQueue.Enqueue(newItem);
        return aQueue;
    }
}