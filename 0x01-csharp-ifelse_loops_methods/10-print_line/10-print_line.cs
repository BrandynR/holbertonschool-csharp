using System;

    class Line
    {
        public static void PrintLine(int length)
        {
            int x = 0;
            if (length > 0)
            {
                for (x = 0; x <= length; x++)
                {
                    Console.Write("_");
                }
            }
            else
            {
                Console.WriteLine("\n");
            }
        }
    }
    