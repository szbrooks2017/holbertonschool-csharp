﻿using System;
using System.Collections.Generic;

///<summary> Class for matrices</summary>
class MatrixMath
{
    ///<summary>method that returns inverse</summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        int row = matrix.GetLength(0);
        int column = matrix.GetLength(1);
        double[,] bad = new double[,] {{-1}};
        double det = Math.Round((matrix[0,0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]), 2);

        if (row == 2 && column == 2)
        {
            if (det == 0)
            {
                return bad;
            }
            else
            {
                double[,] inverse = {{Math.Round((1 / det) * matrix[1, 1], 2), Math.Round((1 / det) * -matrix[0, 1], 2)}, {Math.Round((1 / det) * -matrix[1, 0], 2), Math.Round((1 / det) * matrix[0, 0],2)}};
                return inverse;  
            }
        }
        else
        {
            return bad;
        }
    }
}
