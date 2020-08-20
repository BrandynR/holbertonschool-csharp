using System;
using System.Collections.Generic;

    /// <summary> Object class</summary>
    class Obj
    {

    /// <summary>method that returns True if the object is an instance of
    /// or if the object is an instance of a class that inherited from, Array</summary>
    ///<returns> True or False </returns>

        public static bool IsInstanceOfArray(object obj)
        {
            return typeof(Array).IsInstanceOfType(obj);
        }
    }
