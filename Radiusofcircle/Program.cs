using System;

namespace RadiusOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            double pi = 3.14;
            double a = pi * r * r;
            Console.WriteLine("Radius of the circle :" + (r));
            Console.WriteLine("Area of the circle :" + (a));

        }
    }
}