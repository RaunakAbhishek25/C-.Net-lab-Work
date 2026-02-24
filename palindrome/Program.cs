using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int originalNum = num;
        int reverseNum = 0;

        while (num > 0)
        {
            int digit = num % 10;
            reverseNum = reverseNum * 10 + digit;
            num = num / 10;
        }

        if (originalNum == reverseNum)
            Console.WriteLine("The number is a palindrome.");
        else
            Console.WriteLine("The number is not a palindrome.");
    }
}