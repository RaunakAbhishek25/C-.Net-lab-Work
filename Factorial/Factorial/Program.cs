using System;

namespace Factorial
{
	class FactorialProgram
	{
		static void Main()
		{
			long fact = 1;

			Console.WriteLine("Enter a number: ");
			int n = int.Parse(Console.ReadLine()); //Convert.ToInt32

			for (int i = 1; i <= n; i++)
			{
				fact = fact * i;
			}

			Console.WriteLine("Factorial is: " + fact);
		}
	}
}