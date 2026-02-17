using System;

namespace SumOfNumbers
{
    class Program
    {
        static void Main()
        {
            int n, sum = 0;

            Console.WriteLine("Enter number of elements ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter number " + i + ": ");
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }

            Console.WriteLine("Sum of numbers = " + sum);
        }
    }
}