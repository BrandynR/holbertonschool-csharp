using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
		for (char alph = 'a'; alph <= 'z'; alph++) {
		    if (alph == 'e' || alph == 'q') { continue;}
		    Console.Write(alph);
		}
        }
    }
}
