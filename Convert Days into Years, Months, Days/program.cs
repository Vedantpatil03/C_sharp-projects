using System;

class Program
{
    static void Main()
    {
        int days, years, months, remainingDays;

        Console.Write("Enter total days: ");
        days = Convert.ToInt32(Console.ReadLine());

        years = days / 365;
        months = (days % 365) / 30;
        remainingDays = (days % 365) % 30;

        Console.WriteLine("Years: " + years);
        Console.WriteLine("Months: " + months);
        Console.WriteLine("Days: " + remainingDays);
    }
}
