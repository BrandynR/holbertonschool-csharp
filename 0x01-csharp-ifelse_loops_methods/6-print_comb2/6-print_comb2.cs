using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
        string coma= "";
        int y;
        int z;
        for (y = 0; y <= 9; y++)
            { 
            for (z = y + 1; z <= 9; z++)
                {
                Console.Write("{0}{1:d}{2:d}",coma, y, z);
                coma = ", ";
                } 
            }
        Console.Write("\n");
        }
    }
}
