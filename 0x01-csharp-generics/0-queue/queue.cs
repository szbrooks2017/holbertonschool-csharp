using System;

///<summary>Custome Queue class</summary>
class Queue<T>
{
    ///<summary> Method that returns the type</summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}
