// using System;

class Rectangle
{
    // Instance variables
    private double length;
    private double width;

    // Default constructor
    public Rectangle()
    {
        length = 0;
        width = 0;
    }

    // Parameterized constructor
    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    // Method to calculate area
    public double Area()
    {
        return length * width;
    }

    // Method to display values
    public void Display()
    {
        Console.WriteLine("Length: " + length);
        Console.WriteLine("Width: " + width);
        Console.WriteLine("Area: " + Area());
    }
}

class Program
{
    static void Main()
    {
        // Object using default constructor
        Rectangle r1 = new Rectangle();
        Console.WriteLine("Rectangle 1 (Default Constructor)");
        r1.Display();

        Console.WriteLine();

        // Object using parameterized constructor
        Rectangle r2 = new Rectangle(10, 5);
        Console.WriteLine("Rectangle 2 (Parameterized Constructor)");
        r2.Display();
    }
}
