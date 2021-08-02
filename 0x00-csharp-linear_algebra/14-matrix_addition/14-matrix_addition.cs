using System;

///<summary>Class for matrices.</summary>
class MatrixMath
{
    ///<summary>Returns the sum of two matrices.</summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] matrix3;

        if (matrix1.GetLength(0) != matrix2.GetLength(1))
        {
            return -1;
        }

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return matrix3;
    }
}
