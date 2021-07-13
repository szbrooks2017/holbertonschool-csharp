using System;

class Program
{
    static void Main(string[] args)
    {
        string expression;
        for (int i = 0; i <= 99; i++)
        {
            if (i < 10)
            {
                expression = "0{0}, ";
            }
            else if (i == 99)
            {
                expression = "{0}\n";
            }
            else
            {
                expression = "{0}, ";
            }
            Console.Write(expression, i);   
        }
    }
}