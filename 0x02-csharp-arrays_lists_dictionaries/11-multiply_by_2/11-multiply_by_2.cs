using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> newDict = new Dictionary<string, int>();

        foreach (var item in myDict.Keys)
        {
            newDict[item] = myDict[item] * 2;
        }
        return newDict;
    }
}
