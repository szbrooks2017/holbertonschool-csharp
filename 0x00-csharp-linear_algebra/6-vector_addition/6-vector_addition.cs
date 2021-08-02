using System;

///<summary>A class for Vectors.</summary>
class VectorMath
{
    ///<summary>Returns teh sum of a 2d/3d vector.</summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] newVector = new double[1] {-1};

        if (vector1.Length == 2 || vector2.Length == 2)
            newVector = new double[2] {(vector1[0] + vector2[0]), (vector1[1] + vector2[1])};
        else if (vector1.Length == 3 || vector2.Length == 3)
            newVector = new double[3] {(vector1[0] + vector2[0]), (vector1[1] + vector2[1]), (vector1[2] + vector2[2])};
        return newVector;
    }
}