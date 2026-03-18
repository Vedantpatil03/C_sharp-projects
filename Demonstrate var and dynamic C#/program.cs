using System;

class Program
{
    static void Main()
    {
        var x = 10; // type inferred as int
        Console.WriteLine("Var value: " + x);

        dynamic y = 20;
        Console.WriteLine("Dynamic int: " + y);

        y = "Hello";
        Console.WriteLine("Dynamic string: " + y);
    }
}
