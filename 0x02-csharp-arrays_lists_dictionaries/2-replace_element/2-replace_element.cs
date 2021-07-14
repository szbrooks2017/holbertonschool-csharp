using System;

// return updated array
// replace an element at a given index
class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        if (index >= 0 && index < array.Length)
        {
            array[index] = n;
        }
        else
        {
            Console.WriteLine("Index out of range");
        }
        return array;
    }
}