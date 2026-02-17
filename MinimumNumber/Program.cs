using System;

namespace MinimumNumber
{
    class MinimumOfThree
    {
        static void Main()
        {
            int a, b, c;

            Console.Write("Enter first number: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            c = int.Parse(Console.ReadLine());

            if (a <= b && a <= c)
            {
                Console.WriteLine("Minimum number is: " + a);
            }
            else if (b <= a && b <= c)
            {
                Console.WriteLine("Minimum number is: " + b);
            }
            else
            {
                Console.WriteLine("Minimum number is: " + c);
            }
        }
    }
}