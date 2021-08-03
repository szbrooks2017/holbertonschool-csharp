﻿using System;

///<summary> Class for matrices</summary>
class MatrixMath
{
    ///<summary>Determines the cross product of two vectors</summary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        int row = matrix.GetLength(0);
        int column = matrix.GetLength(1);
        double[] bad = new double[] {-1};
        double[] cross = new double[3];

        if (row != 3 && row != column)
        {
            return bad;
        }

        cross[0] = (vector1[1] * vector2[2]) - (vector2[2] * vector2[1]);
        cross[1] = (vector1[2] * vector2[0]) - (vector1[0] * vector2[2]);
        cross[2] = (vector1[0] * vector2[1]) - (vector1[1] * vector2[0]);
        return cross;
        }
    }
}