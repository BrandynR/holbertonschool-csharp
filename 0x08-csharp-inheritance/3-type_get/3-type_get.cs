using System;
using System.Collections.Generic;
using System.Reflection;


    /// <summary> Object class</summary>
    class Obj
    {
       ///<summary>method that prints the names of the available properties and methods of an object</summary>
       ///<returns> All properties of an object</returns>
    public static void Print(object myObj)
	{
		TypeInfo idx = myObj.GetType().GetTypeInfo();
		Console.WriteLine("{0} Properties:", idx.Name);
		foreach (PropertyInfo prop in idx.GetProperties())
		{
			Console.WriteLine(prop.Name);
		}

		Console.WriteLine("{0} Methods:", idx.Name);
		foreach (MethodInfo metInfo in idx.GetMethods())
		{
			Console.WriteLine(metInfo.Name);
		}
	}
    }
