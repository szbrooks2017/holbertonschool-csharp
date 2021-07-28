using System;
using System.Reflection;

///<summary>Creates an Obj class that checks an obj.</summary>
class Obj
{
    ///<summary>Prints the available properties for myObj.</summary>
    public static void Print(object myObj)
    {
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