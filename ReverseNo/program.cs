using System;

class ReverseNumber
{
    static void Main()
    {
        int number, reverse = 0, remainder;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        int originalNumber = number;

        while (number != 0)
        {
            remainder = number % 10;
            reverse = reverse * 10 + remainder;
            number = number / 10;
        }

        Console.WriteLine("Reverse of " + originalNumber + " is: " + reverse);
        Console.ReadLine();
    }
}
