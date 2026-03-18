using System;

class Program
{
    readonly int y;

    public Program()
    {
        y = 20; // readonly initialized in constructor
    }

    static void Main()
    {
        const double PI = 3.14; // constant

        Program obj = new Program();

        Console.WriteLine("Constant PI = " + PI);
        Console.WriteLine("Readonly value = " + obj.y);
    }
}
