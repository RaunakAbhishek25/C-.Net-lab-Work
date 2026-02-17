using System;

namespace MyApplication
{
     class ArithmeticOperations
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
            Console.WriteLine("First number is : " + (a));
			Console.WriteLine("First number is : " + (b));
			Console.WriteLine("Addition is : " + (a + b));
			Console.WriteLine("Subtraction is : " + (a - b));
			Console.WriteLine("Multiplication is : " + (a * b));
			Console.WriteLine("Division is : " + (a / b));
			Console.WriteLine("Modulus is : " + (a % b));

		}
    }
}
