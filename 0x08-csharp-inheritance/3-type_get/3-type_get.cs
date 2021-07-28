using System;
using System.Reflection;

class Obj
{
    ///<summary>prints the available properties</summary>
    ///<param name="myObj">Object input</param>
    public static void Print(object myObj)
    {
        // for properties
        Type tMeth = myObj.GetType();
        Type tProp = myObj.GetType();
        PropertyInfo[] pi = tProp.GetProperties();
        MethodInfo[] mi = tMeth.GetMethods();

        Console.WriteLine(myObj.GetType().Name + "Properties:");
        foreach (PropertyInfo p in pi)
        {
            Console.WriteLine(p.Name);
        }
        Console.WriteLine(myObj.GetType().Name + "Methods:");
        foreach (MethodInfo m in mi)
        {
            Console.WriteLine(m.Name);
        }
    }
}