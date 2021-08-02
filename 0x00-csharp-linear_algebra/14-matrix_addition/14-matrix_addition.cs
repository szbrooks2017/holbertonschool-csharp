﻿using System;

///<summary>Class for matrices.</summary>
class MatrixMath
{
    ///<summary>Returns the sum of two matrices.</summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] matrix3;
        double[,] bad = new double[,] {{-1}};
        int row = matrix1.GetLength(0);
        int column = matrix2.GetLength(1);


        if (column == 2 && row == 2 && column == row)
        {
            matrix3 = new double[2, 2];
        }
        else if (column == 3 && row == 3 && column == row)
        {
            matrix3 = new double[3, 3];
        }
        else
        {
            return bad;
        }

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return matrix3;
    }
}
