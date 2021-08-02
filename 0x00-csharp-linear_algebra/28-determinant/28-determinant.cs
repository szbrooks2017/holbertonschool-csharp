using System;

///<summary> Class for matrices</summary>
class MatrixMath
{
    ///<summary>Determines the determinant of a matrix</summary>
    public static double Determinant(double[,] matrix)
    {
        int det = 0;

        for(int i = 0; i < 3; i++)
        {
            det += (matrix[0, i] * (matrix[1, (i + 1) % 3] * matrix[2, (i + 2) % 3] - matrix[1, (i + 2) % 3] * matrix[2, (i + 1) % 3]));
        }
        return det;
    }
}