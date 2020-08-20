using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary> Obj class </summary>
class Obj
{
    /// <summary> Lists all methods and properties of an object </summary>
    public static void Print(object myObj)
    {
        Type type = myObj.GetType();

        Console.WriteLine("{0} Properties:", type.Name);
        foreach (var property in type.GetProperties())
            Console.WriteLine(property.Name);
        Console.WriteLine("{0} Methods:", type.Name);
        foreach (var method in type.GetMethods())
            Console.WriteLine(method.Name);
    }
}
