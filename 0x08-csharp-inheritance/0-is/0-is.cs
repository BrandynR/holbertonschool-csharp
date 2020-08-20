using System;
using System.Collections.Generic;

    /// <summary> Object class</summary>
    class Obj
    {

    /// <summary>method that returns True if the object is an int, otherwise return False</summary>
  	///<returns>True or False</returns>
    public static bool IsOfTypeInt(object obj)
        {
            return obj is int;
        }
    }
