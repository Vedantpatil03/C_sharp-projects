using System;

class ArmstrongNumber
{
    static void Main()
    {
        int number, originalNumber, remainder, result = 0, n = 0;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        originalNumber = number;

        // Count digits
        while (originalNumber != 0)
        {
            originalNumber /= 10;
            n++;
        }

        originalNumber = number;

        // Calculate Armstrong
        while (originalNumber != 0)
        {
            remainder = originalNumber % 10;
            result += (int)Math.Pow(remainder, n);
            originalNumber /= 10;
        }

        if (result == number)
            Console.WriteLine(number + " is an Armstrong number.");
        else
            Console.WriteLine(number + " is NOT an Armstrong number.");

        Console.ReadLine();
    }
}
