using System;

class Program
{
    static void Main()
    {
        int[] marks = new int[5];
        int sum = 0;
        double average;

        // Input marks
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter marks of student " + (i + 1) + ": ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Calculate sum
        for (int i = 0; i < 5; i++)
        {
            sum += marks[i];
        }

        // Calculate average
        average = sum / 5.0;

        // Display result
        Console.WriteLine("Total Marks = " + sum);
        Console.WriteLine("Average Marks = " + average);
    }
}