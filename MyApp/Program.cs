using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== User Details ===");

        string name = Prompt("Enter your name");
        int age = PromptInt("Enter your age");
        string email = Prompt("Enter your email");

        Console.WriteLine();
        Console.WriteLine("You entered:");
        Console.WriteLine($"Name : {name}");
        Console.WriteLine($"Age  : {age}");
        Console.WriteLine($"Email: {email}");
    }

    // Prompt for a string value.
    private static string Prompt(string label)
    {
        Console.Write(label + ": ");
        return Console.ReadLine() ?? string.Empty;
    }

    // Prompt for an integer, reprompting on invalid input.
    private static int PromptInt(string label)
    {
        while (true)
        {
            Console.Write(label + ": ");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                return value;
            }

            Console.WriteLine("Please enter a valid whole number.");
        }
    }
}
