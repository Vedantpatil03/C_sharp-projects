using System;

class Program
{
    static void Main()
    {
        int? num = null;

        if (num.HasValue)
            Console.WriteLine("Value: " + num.Value);
        else
            Console.WriteLine("Value is NULL");

        num = 10;
        Console.WriteLine("Now Value: " + num);
    }
}
