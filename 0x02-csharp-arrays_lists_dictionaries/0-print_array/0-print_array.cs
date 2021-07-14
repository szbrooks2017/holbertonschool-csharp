using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        // int should start with 0, increment by one
        // if size is 0 print blank line
        // if size < 0 print size cannot be negative return null
        int[] newArray = new int[size];
        
        if (size == 0)
        {
            Console.WriteLine("");
        }

        if (size <= 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        for (int i = 0; i < size; i++)
        {
           if (newArray[i] < size - 1)
           {
               Console.Write(i + " ");
           } 
            else
            {
                Console.WriteLine("");
            }
        }
        return newArray;
    }
}

