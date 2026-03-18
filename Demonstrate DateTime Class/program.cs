using System;

class Program
{
    static void Main()
    {
        DateTime now = DateTime.Now;

        Console.WriteLine("Current Date and Time: " + now);
        Console.WriteLine("Date: " + now.ToShortDateString());
        Console.WriteLine("Time: " + now.ToShortTimeString());

        DateTime future = now.AddDays(5);
        Console.WriteLine("Date after 5 days: " + future);
    }
}
