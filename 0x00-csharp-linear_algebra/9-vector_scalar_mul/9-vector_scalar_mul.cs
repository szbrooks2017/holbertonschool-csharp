using System;

///<summary>Class for Vectors.</summary>
class VectorMath
{
    ///<summary>Multiplies a vector by a scalar.</summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double result = new double[1] {-1};

        if (vector.Length == 2 || vector.Length == 3)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                result[i] = vector[i] * scalar;
            }
        }
        return result;
    }
}
