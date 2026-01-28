using System;

namespace DisplayUserDetailed
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display program title
            Console.WriteLine("=== User Details Registration ===\n");

            // Collect user information
            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter your email address: ");
            string email = Console.ReadLine();

            Console.Write("Enter your phone number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter your city: ");
            string city = Console.ReadLine();

            Console.Write("Enter your country: ");
            string country = Console.ReadLine();

            Console.Write("Enter your occupation: ");
            string occupation = Console.ReadLine();

            // Display collected information
            Console.WriteLine("\n=== User Details Summary ===");
            Console.WriteLine($"Full Name:    {fullName}");
            Console.WriteLine($"Age:          {age} years old");
            Console.WriteLine($"Email:        {email}");
            Console.WriteLine($"Phone:        {phoneNumber}");
            Console.WriteLine($"Location:     {city}, {country}");
            Console.WriteLine($"Occupation:   {occupation}");
            Console.WriteLine("\nThank you for providing your details!");
        }
    }
}
