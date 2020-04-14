using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
	int last = number % 10;
	string status = " ";

	if (last < 6 && last != 0) { status = " and is less than 6 and not 0"; }
	else if (last > 5) { status = " and is greater than 5"; }
	else { status = " and is 0"; }

	Console.WriteLine(String.Format("The last digit of {0} is {1}{2}", number, last, status));
    }
}
