using System;
using System.Reflection;

class Obj
{
    ///<summary>prints the available properties</summary>
    ///<param name="myObj">Object input</param>
    public static void Print(object myObj)
    {
        // for properties
        PropertyInfo[] pi = myObj.GetType().GetProperties();
        MethodInfo[] mi = myObj.GetType().GetMethods();

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