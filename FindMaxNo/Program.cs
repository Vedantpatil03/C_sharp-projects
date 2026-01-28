using System;

namespace DisplayUserDetailed
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display program title
            Console.WriteLine("=== Find Maximum of Two Numbers ===\n");

            // Get first number
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            // Get second number
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            // Find maximum
            int maximum = num1 > num2 ? num1 : num2;

            // Display result
            Console.WriteLine($"\nThe maximum number is: {maximum}");
            Console.WriteLine("\nThank you for using the program!");
        }
    }
}
