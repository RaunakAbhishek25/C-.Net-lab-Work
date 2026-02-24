using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int originalNum = num;
        int sum = 0;
        int digits = num.ToString().Length;

        while (num > 0)
        {
            int digit = num % 10;
            sum += (int)Math.Pow(digit, digits);
            num /= 10;
        }

        if (sum == originalNum)
            Console.WriteLine($"{originalNum} is an Armstrong number.");
        else
            Console.WriteLine($"{originalNum} is not an Armstrong number.");
    }
}