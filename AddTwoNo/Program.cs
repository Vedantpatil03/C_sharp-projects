using System;

namespace DisplayUserDetailed
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display program title
            Console.WriteLine("=== Add Two Numbers ===\n");

            // Get first number
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            // Get second number
            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            // Calculate sum
            double sum = num1 + num2;

            // Display result
            Console.WriteLine($"\nResult: {num1} + {num2} = {sum}");
            Console.WriteLine("\nThank you for using the calculator!");
        }
    }
}
