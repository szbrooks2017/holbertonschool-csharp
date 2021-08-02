using System;

///<summary>Class for matrices.</summary>
class MatrixMath
{
    ///<summary>Method that mulitplies a matrix by a Matrix.</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int row = matrix1.GetLength(0);
        int column = matrix1.GetLength(1);
        int row2 = matrix2.GetLength(0);
        int column2 = matrix2.GetLength(1);
        double temp = 0;
        double[,] matrix3 = new double[row, column2];
        double[,] bad = new double[,] {{-1}};

        if (column != row2)
        {
            return bad;
        }
        else
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column2; j++)
                {
                    temp = 0;
                    for (int k = 0; k < column; k++)
                    {
                        temp += matrix1[i, k] * matrix2[k, j];
                    }
                    matrix3[i, j] = temp;
                }
            }
            return matrix3;
        }
    }
}