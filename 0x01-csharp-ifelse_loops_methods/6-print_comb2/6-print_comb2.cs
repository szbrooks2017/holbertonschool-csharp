﻿using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 8; i++)
        {
            for (int j = 0; j <= 9; j++)
            {
                if (i != j && i < 9 && i < j)
                {
                    if (i == 8 && j == 9)
                    {
                        Console.WriteLine("{0}{1}", i, j);
                    }
                    else
                    {
                        Console.Write("{0}{1}, ", i, j);
                    }
                }
            }
        }
    }
}