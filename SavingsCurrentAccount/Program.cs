using System;

class Account
{
    protected int accountNumber;
    protected double balance;

    public Account(int accNo, double bal)
    {
        accountNumber = accNo;
        balance = bal;
    }

    public virtual void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Deposited: " + amount);
    }

    public virtual void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }

    public void Display()
    {
        Console.WriteLine("Account No: " + accountNumber);
        Console.WriteLine("Balance: " + balance);
    }
}

class SavingsAccount : Account
{
    double interestRate;

    public SavingsAccount(int accNo, double bal, double rate)
        : base(accNo, bal)
    {
        interestRate = rate;
    }

    public override void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Savings Withdraw: " + amount);
        }
        else
        {
            Console.WriteLine("Not enough balance in Savings");
        }
    }
}

class CurrentAccount : Account
{
    double overdraftLimit;

    public CurrentAccount(int accNo, double bal, double limit)
        : base(accNo, bal)
    {
        overdraftLimit = limit;
    }

    public override void Withdraw(double amount)
    {
        if (amount <= balance + overdraftLimit)
        {
            balance -= amount;
            Console.WriteLine("Current Withdraw: " + amount);
        }
        else
        {
            Console.WriteLine("Overdraft limit exceeded");
        }
    }
}

class Program
{
    static void Main()
    {
        SavingsAccount s = new SavingsAccount(101, 5000, 4);
        s.Deposit(1000);
        s.Withdraw(2000);
        s.Display();

        Console.WriteLine();

        CurrentAccount c = new CurrentAccount(102, 3000, 2000);
        c.Deposit(500);
        c.Withdraw(4000);
        c.Display();
    }
}