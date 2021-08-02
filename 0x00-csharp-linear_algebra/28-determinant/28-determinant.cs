using System;

///<summary> Class for matrices</summary>
class MatrixMath
{
    ///<summary>Determines the determinant of a matrix</summary>
    public static double Determinant(double[,] matrix)
    {
        int row = matrix.GetLength(0);
        int column = matrix.GetLength(1);

        if (row == 2 && row == column)
        {
            return Math.Round((matrix[0,0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]), 2);
        }
        else if (row ==3 && row == column)
        {
            double a = matrix[0, 0] * ((matrix[1, 1] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 1]));
            double b = matrix[0, 1] * ((matrix[1, 0] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 0]));
            double c = matrix[0, 2] * ((matrix[1, 0] * matrix[2, 1]) - (matrix[1, 1] * matrix[2, 0]));
            return Math.Round((a - b + c), 2);
        }
        else
        {
            return -1;
        }
    }
}