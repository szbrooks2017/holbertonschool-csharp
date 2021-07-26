using System;

namespace MyMath
{
    public class Matrix
    {
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
            {
                return null;
            }

            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }

        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        for(int x = 0; x < rows; x++)
        {
            for(int y = 0; y < columns; y++)
            {
                matrix[x, y] = matrix[x, y] / num;
            }
        }
        return matrix;
        }
    }
}
