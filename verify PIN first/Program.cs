using System;

class ATM
{
    static void Main()
    {
        int correctPin = 151631;
        double balance = 10000; // Initial balance

        Console.Write("Enter your PIN: ");
        int enteredPin = Convert.ToInt32(Console.ReadLine());

        if (enteredPin == correctPin)
        {
            Console.WriteLine("PIN Verified Successfully ✅");

            Console.Write("Enter withdrawal amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Withdrawal Successful ✅");
                Console.WriteLine("Remaining Balance: ₹{0:F2}", balance);
            }
            else
            {
                Console.WriteLine("Insufficient Balance ❌");
            }
        }
        else
        {
            Console.WriteLine("Incorrect PIN ❌ Access Denied");
        }

        Console.ReadLine();
    }
}
