using System;

///<summary> return true if the obj is an instance of a class that inherits, else false</summary>
class Obj
{
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}
