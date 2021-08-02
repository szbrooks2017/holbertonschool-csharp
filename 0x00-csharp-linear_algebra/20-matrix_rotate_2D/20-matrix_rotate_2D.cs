using System;

///<summary>Class for matrices.</summary>
class MatrixMath
{
    ///<summary>Method that rotates a matrix by a Matrix.</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int row = matrix.GetLength(0);
        int column = matrix.GetLength(1);
        double temp;
        double[,] matrix3 = new double[2, 2];
        double[,] rotate = new double[2, 2] {{Math.Cos(angle), Math.Sin(angle)}, {-1 * Math.Sin(angle), Math.Cos(angle)}};
        double[,] bad = new double[,] {{-1}};

        if (row != 2 || column != 2)
        {
           return bad;
        }
        else
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    temp = 0;
                    for (int k = 0; k < column; k++)
                    {
                        temp += Math.Round(matrix[i, k] * rotate[k, j], 2);
                    }
                    matrix3[i, j] = temp;
                }
            }
            return matrix3;
        }
    }
}