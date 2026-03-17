using System;

class Student
{
    int rollNo;
    string name;
    double marks;

    // Default Constructor
    public Student()
    {
        rollNo = 0;
        name = "Unknown";
        marks = 0;
    }

    // Parameterized Constructor
    public Student(int r, string n, double m)
    {
        rollNo = r;
        name = n;
        marks = m;
    }

    // Method to calculate grade
    public string CalculateGrade()
    {
        if (marks >= 80)
            return "A";
        else if (marks >= 60)
            return "B";
        else if (marks >= 40)
            return "C";
        else
            return "Fail";
    }

    // Method to display student details
    public void Display()
    {
        Console.WriteLine("Roll No: " + rollNo);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Marks: " + marks);
        Console.WriteLine("Grade: " + CalculateGrade());
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Using Default Constructor
        Student s1 = new Student();
        Console.WriteLine("Student 1 Details:");
        s1.Display();

        Console.WriteLine();

        // Using Parameterized Constructor
        Student s2 = new Student(101, "Raunak Abhishek", 95);
        Console.WriteLine("Student 2 Details:");
        s2.Display();

        Console.ReadLine();
    }
}