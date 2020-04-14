using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
           
           int x;
           for (x = 1; x <= 100; x++)
           {
               if (x % 3 == 0 && x % 5 == 0)
               {
                Console.Write("FizzBuzz ");
               }
               else if (x % 5 == 0)
               {
                   Console.Write("Buzz ");
               }
               else if (x % 3 == 0)
               {
                   Console.Write("Fizz ");
               }
               else
               {
                    Console.Write("{0} ",x);
               }
           }
           Console.WriteLine();
        }
    }
}
