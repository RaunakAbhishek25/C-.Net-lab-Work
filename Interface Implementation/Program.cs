using System;

interface IResult
{
    bool Pass(int mark);
}

interface IDivision
{
    string Division(int average);
}

class Student : IResult, IDivision
{
    
    public bool Pass(int mark)
    {
        return mark >= 50;
    }

    public string Division(int average)
    {
        if (average >= 60)
            return "First Division";
        else if (average >= 50)
            return "Second Division";
        else if (average >= 40)
            return "Third Division";
        else
            return "Fail";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();

        Console.Write("Enter marks: ");
        int mark = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter average: ");
        int avg = Convert.ToInt32(Console.ReadLine());

        if (s.Pass(mark))
            Console.WriteLine("Result: Pass");
        else
            Console.WriteLine("Result: Fail");

        Console.WriteLine("Division: " + s.Division(avg));
    }
}