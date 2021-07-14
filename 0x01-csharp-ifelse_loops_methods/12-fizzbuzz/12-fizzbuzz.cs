using System;

class Fizzbuzz
{
    static void Main(string[] args)
    {
        for (int num = 0; num < 101; num++)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.Write("FizzBuzz");
            }
            else if (num % 3 == 0)
            {
                Console.Write("Fizz");
            }
            else if (num % 5 == 0)
            {
                Console.Write("Buzz");
            }
            else
            {
                Console.Write(num);
            }
        }
    }
}