using System;

namespace MyMath
{
    ///<summary> method divide elements of a matrix</summary>
    public class Matrix
    {
        ///<summary>method that divides the element by a number</summary>
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
