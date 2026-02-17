using System;

namespace Fibonacci
{
	class FibonacciProgram
	{
		static void Main()
		{
			int n, a = 0, b = 1, c;

			Console.WriteLine("Enter the number : ");
			n = int.Parse(Console.ReadLine());

			Console.WriteLine("Fibonacci Series: ");

			for (int i = 1; i <= n; i++)
			{
				Console.Write(a + " ");
				c = a + b;
				a = b;
				b = c;
			}
		}
	}
}