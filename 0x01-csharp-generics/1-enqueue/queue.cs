using System;

///<summary>Custome Queue class</summary>
class Queue<T>
{
    public Node head = null;
    public Node tail = null;
    public int count;

    ///<summary> Public class Node that sets a linked list</summary>
    public class Node 
    {
        public T value = default(T);
        public Node next = null; 

        public Node(T n)
        {
            value = n;
        }
    }

    ///<summary> Method that returns the type</summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    ///<summary> Method that creates/adds new node to the end</summary>
    public void Enqueue(T value)
    {
        Node newnode = new Node(value);

        if (head == null)
        {
            head = newnode;
        }
        else if (tail == null)
        {
            tail = newnode;
        }
        else
        {
            tail.next = newnode;
            tail = newnode;
        }

        count++;
    }

    ///<summary> Method that returns the count</summary>
    public int Count()
    {
        return count;
    }
}
