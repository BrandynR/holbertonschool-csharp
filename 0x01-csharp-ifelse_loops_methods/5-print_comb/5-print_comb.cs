using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
		int num = 0;
		string status = "";


		while (num < 100) {
		      Console.Write(String.Format("{0:d2}", num));
		      if (num < 99) { status = ", "; }
		      else { status = "\n"; }
		      Console.Write(String.Format("{0}", status));
		      num++;
		      }
        }
    }
}
