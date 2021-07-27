using System;

///<summary> return true if the obj is an instance of or if the obj</summary>
///<summary> is an instance from array</summary>
class Obj
{
    ///<summary> method that returns true if an instance of inherited class else false</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        return (obj is Array);
    }
}