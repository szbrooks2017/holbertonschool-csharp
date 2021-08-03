using System;

class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
    {
        int row = matrix.GetLength(0);
        int column = matrix.GetLength(1);
        double[,] bad = new double[,] {{-1}};
        double det = (matrix[0,0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]);

        if (row == 2 && column == 2)
        {
            double[,] inverse = {{(1 / det) * matrix[1, 1], (1 / det) * -matrix[0, 1]}, {(1 / det) * -matrix[1, 0], (1 / det) * matrix[0, 0]}};
            return inverse;
        }
        else
        {
            return bad;
        }
    }
}
