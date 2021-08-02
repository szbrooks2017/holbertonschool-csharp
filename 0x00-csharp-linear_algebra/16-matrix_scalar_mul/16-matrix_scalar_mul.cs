using System;

class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] matrix3;
        double[,] bad = new double[,] {{-1}};
        int row = matrix1.GetLength(0);
        int column = matrix1.GetLength(1);
        int row2 = matrix2.GetLength(0);

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
            matrix3[i] = matrix[i] * scalar;
        }
        return matrix3;
    }
}