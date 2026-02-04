using System;

class SwapNumbers
{
    static void Main()
    {
        int a = 10, b = 20;

        Console.WriteLine("Before Swap: a = " + a + ", b = " + b);

        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine("After Swap: a = " + a + ", b = " + b);
    }
}
