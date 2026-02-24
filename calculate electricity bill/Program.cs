using System;

class ElectricityBill
{
    static void Main()
    {
        Console.Write("Enter total electricity units consumed: ");
        double units = Convert.ToDouble(Console.ReadLine());

        double bill = 0;

        // Slab calculation
        if (units <= 100)
        {
            bill = units * 1.5;
        }
        else if (units <= 200)
        {
            bill = (100 * 1.5) + ((units - 100) * 2.5);
        }
        else
        {
            bill = (100 * 1.5) + (100 * 2.5) + ((units - 200) * 4);
        }

        // Add fixed meter charge
        bill += 50;

        // Apply GST if bill exceeds 500
        if (bill > 500)
        {
            double gst = bill * 0.18;
            bill += gst;
            Console.WriteLine("GST Applied: ₹{0:F2}", gst);
        }

        Console.WriteLine("Total Electricity Bill: ₹{0:F2}", bill);
        Console.ReadLine();
    }
}
