using System;

class CountDigits
{
    static void Main()
    {
        int number, count = 0;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        while (number != 0)
        {
            number /= 10;
            count++;
        }

        Console.WriteLine("Total digits: " + count);
        Console.ReadLine();
    }
}
