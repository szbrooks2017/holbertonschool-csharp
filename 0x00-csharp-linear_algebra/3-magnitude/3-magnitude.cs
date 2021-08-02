using System;
using System.Collections.Generic;

///<summary>A class for vectors.</summary>
class VectorMath
{
    ///<summary>A method that returns the length of a 2d or 3d vector.</summary>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length == 2)
        {
            double result = (Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2)));
            return (Math.Round(result, 2));
        }
        else if (vector.Length == 3)
        {
            double result = (Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2)));
            return (Math.Round(result, 2));
        }
        else
        {
            return -1;
        }
    }
}
