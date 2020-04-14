using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
                 for (int hundred = 0; hundred <= 98; hundred++) {
		     Console.WriteLine(String.Format("{0} = 0x{0:x}", hundred, hundred)); }
        }
    }
}
