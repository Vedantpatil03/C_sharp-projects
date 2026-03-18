using System;

class Program
{
    static void Main()
    {
        int choice;

        Console.WriteLine("1. Sunday");
        Console.WriteLine("2. Monday");
        Console.WriteLine("3. Tuesday");
        Console.Write("Enter your choice: ");

        choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}
