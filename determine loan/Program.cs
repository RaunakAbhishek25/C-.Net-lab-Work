using System;

class LoanEligibility
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your monthly income: ");
        double income = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your credit score: ");
        int creditScore = Convert.ToInt32(Console.ReadLine());

        // Nested Conditions
        if (age >= 21 && age <= 60)
        {
            if (income >= 25000)
            {
                if (creditScore >= 750)
                {
                    Console.WriteLine("Loan Status: Fully Eligible ✅");
                }
                else if (creditScore >= 650)
                {
                    Console.WriteLine("Loan Status: Eligible with Conditions ⚠");
                }
                else
                {
                    Console.WriteLine("Loan Status: Not Eligible ❌ (Low Credit Score)");
                }
            }
            else
            {
                Console.WriteLine("Loan Status: Not Eligible ❌ (Insufficient Income)");
            }
        }
        else
        {
            Console.WriteLine("Loan Status: Not Eligible ❌ (Age Criteria Not Met)");
        }

        Console.ReadLine();
    }
}
