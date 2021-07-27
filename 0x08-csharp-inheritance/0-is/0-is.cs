using System;

///<summary> wite a method that returns true if the obj is an int</summary>
class Obj
{
    ///<summary> true if obj is an int, else false</summary>
    public static bool IsOfTypeInt(object obj)
    {
        if(obj is int)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
