using System;

///<summary> Class for matrices</summary>
class MatrixMath
{
    ///<summary> Transpose a matrix</summary>
    public static double[,] Transpose(double[,] matrix)
    {
        int row = matrix.GetLength(0);
        int column = matrix.GetLength(1);
        double[,] matrix3 = new double[column, row];

        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < column; j++)
            {
                matrix3[j, i] = matrix[i, j];
            }
        }
        return matrix3;
    }
}
