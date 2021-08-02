using System;

///<summary> Class for matrices.</summary>
class MatrixMath
{
    ///<summary> Method that shears a 2D matrix</summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        int row = matrix.GetLength(0);
        int column = matrix.GetLength(1);
        double[,] matrix3 = new double[2, 2];
        double[,] shear = new double[2, 2] {{1, 0}, {0, 1}};
        double[,] bad = new double[,] {{-1}};


        if (row != 2 || column != 2)
        {
           return bad;
        }

        if (direction == 'x')
        {
            shear[1, 0] = factor;
        }
        else if (direction == 'y')
        {
            shear[0, 1] = factor;
        }
        else
        {
            return bad;
        }
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    matrix3[i, j] += (matrix[i, k] * shear[k, j]);
                }
            }
        }
        return matrix3;
    }
}