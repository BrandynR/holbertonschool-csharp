using System;
using System.Collections.Generic;

    /// <summary> Object class</summary>
    class Obj
    {

    /// <summary>method that returns True if the object is an instance of a class that
    /// inherits from the specified class, otherwise return False</summary>
    ///<returns> True or False </returns>

        public static bool IsOnlyASubclass(Type derivedType, Type baseType)
        {
            return derivedType.IsSubclassOf(baseType);
        }
    }
