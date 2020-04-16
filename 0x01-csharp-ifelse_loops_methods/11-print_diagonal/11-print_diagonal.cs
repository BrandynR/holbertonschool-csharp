using System;

    class Line
    {
        public static void PrintDiagonal(int length)
        {
            int x;
            int y;
            if (length > 0)
            {
                for (x = 0; x < length; x++)
                {
                    for (y = 0; y < x; y++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("\\");
                }
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
    