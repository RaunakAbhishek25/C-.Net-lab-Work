using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string original = input;
        string reverse = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reverse += input[i];
        }

        if (original.Equals(reverse, StringComparison.OrdinalIgnoreCase))
            Console.WriteLine("The string is a palindrome.");
        else
            Console.WriteLine("The string is not a palindrome.");
    }
}
