using System;

///<summary>Class for matrices.</summary>
class MatrixMath
{
    ///<summary>Method that mulitplies a matrix by a scalar.</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] matrix3;
        double[,] bad = new double[,] {{-1}};
        int row = matrix.GetLength(0);
        int column = matrix.GetLength(1);

        if (row == 2 && column == 2)
        {
            matrix3 = new double[2, 2];
        }
        else if (row == 3 && column == 3)
        {
            matrix3 = new double[3, 3];
        }
        else
        {
            return bad;
        }

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j< column; j++)
            {
                matrix3[i, j] = matrix[i, j] * scalar;
            }
        }
        return matrix3;
    }
}