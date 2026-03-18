using System;

enum Days { Sunday, Monday, Tuesday, Wednesday }

class Program
{
    static void Main()
    {
        Days d = Days.Monday;

        Console.WriteLine("Selected Day: " + d);
        Console.WriteLine("Integer Value: " + (int)d);
    }
}
