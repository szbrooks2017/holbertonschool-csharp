using System;
using System.Reflection;

class Obj
{
    ///<summary> prints the available properties</summary>
    ///<param name="myObj">Object input</param>
    public static void Print(object myObj)
    {
        // for properties
        Type t = myObj.GetType();
        PropertyInfo[] pi = t.GetProperties();
        Console.WriteLine(myObj.GetType().Name + "Properties:");
        foreach (PropertyInfo p in pi)
        {
            Console.WriteLine(p.Name);
        }

        // for methods
        Type tt = myObj.GetType();
        MethodInfo[] mi = tt.GetMethods();
        Console.WriteLine(myObj.GetType().Name + "Methods:");
        foreach (MethodInfo m in mi)
        {
            Console.WriteLine(m.Name);
        }
    }
}