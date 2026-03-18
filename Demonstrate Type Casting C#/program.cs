using System;

class Program
{
    static void Main()
    {
        // Implicit Casting
        int num = 10;
        double d = num;

        Console.WriteLine("Implicit Casting (int to double): " + d);

        // Explicit Casting
        double x = 9.78;
        int y = (int)x;

        Console.WriteLine("Explicit Casting (double to int): " + y);
    }
}
