using System;

///<summary>Class for vectors.</summary>
class VectorMath
{
    ///<summary>Method that returns product of 2d/3d vectors.</summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        double result = -1;
        if (vector1.Length == 2 || vector1.Length == 3 && vector1.Length == vector2.Length) 
        {
            result = 0;
            for (int i = 0; i < vector1.Length; i++)
            {
                result += vector1[i] * vector2[i];
            }
            return result;
        }
    }
}