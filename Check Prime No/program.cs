using System;

class PrimeNumber
{
    static void Main()
    {
        int number, count = 0;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                count++;
        }

        if (count == 2)
            Console.WriteLine(number + " is a Prime number.");
        else
            Console.WriteLine(number + " is NOT a Prime number.");

        Console.ReadLine();
    }
}
