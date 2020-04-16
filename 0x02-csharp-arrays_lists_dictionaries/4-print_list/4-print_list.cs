using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        List<int> newList = new List<int>();

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        for (int i = 0; i < size; i++)
        {
            newList.Add(i);
        }
        Console.WriteLine("{0}", String.Join(" ", newList));
        return newList;
    }
}
