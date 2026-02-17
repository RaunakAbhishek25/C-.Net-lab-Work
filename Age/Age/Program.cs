using System;

namespace Age
{
     class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter age of the person :");
            age= int.Parse(Console.ReadLine());
            if (age < 12)
            {
                Console.WriteLine("You are a kid");
            }
            else if (age >= 12 && age <= 17)
            {
                Console.WriteLine("You are a teenager");
            }
            else if (age >= 18 && age <= 60)
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("You are a senior citizen");
			}
           
		}
    }
}
