using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];

        Console.WriteLine("Enter 5 numbers:");

        // Input 5 numbers
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Assume first number is maximum
        int max = numbers[0];

        // Compare remaining numbers
        for (int i = 1; i < 5; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        // Display maximum number
        Console.WriteLine("Maximum number is: " + max);
    }
}