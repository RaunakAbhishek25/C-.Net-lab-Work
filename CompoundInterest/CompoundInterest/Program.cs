using System;

namespace ar
{
    class compoundInterest
    {
        static void main(string[] args)
        {
            double p = double.Parse(Console.ReadLine());
            double r = double.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());
            double ci = p * Math.Pow((1 + r / 100), n) - p;
            Console.WriteLine("Principal Amount is :" + (p));
            Console.WriteLine("Rate of interest is :" + (r));
            Console.WriteLine("Numbers of years is :" + (n));
            Console.WriteLine("Compound Interest is :" + (ci));
        }
    }
}
