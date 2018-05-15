
using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
	int n = number%10;
	if (n > 5)
		Console.WriteLine("Last digit of {0} is {1} and is greater than 5", number, n);
	else
	{
		if (n == 0)
			Console.WriteLine("Last digit of {0} is {1} and is zero", number, n);
		else
			Console.WriteLine("Last digit of {0} is {1} and is less than 5", number, n);
	}
    }
}
