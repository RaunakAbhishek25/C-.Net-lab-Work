using System;

class ElectricityBillWithDiscount
{
    static void Main()
    {
        Console.Write("Enter total electricity units consumed: ");
        double units = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter customer category (Senior/Regular/Industrial): ");
        string category = Console.ReadLine().ToLower();

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

        // Apply discount based on category
        double discount = 0;

        if (category == "senior")
        {
            discount = bill * 0.10;  // 10% discount
        }
        else if (category == "industrial")
        {
            discount = bill * 0.05;  // 5% discount
        }
        else if (category == "regular")
        {
            discount = 0; // No discount
        }
        else
        {
            Console.WriteLine("Invalid category entered.");
            return;
        }

        bill -= discount;

        Console.WriteLine("Discount Applied: ₹{0:F2}", discount);
        Console.WriteLine("Total Electricity Bill after Discount: ₹{0:F2}", bill);

        Console.ReadLine();
    }
}
