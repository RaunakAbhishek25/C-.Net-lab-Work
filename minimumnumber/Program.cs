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

        // Assume first number is minimum
        int min = numbers[0];

        // Compare remaining numbers
        for (int i = 1; i < 5; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        // Display minimum number
        Console.WriteLine("Minimum number is: " + min);
    }
}