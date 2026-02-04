using System;

class CompoundInterest
{
    static void Main()
    {
        Console.Write("Enter Principal: ");
        double p = double.Parse(Console.ReadLine());

        Console.Write("Enter Rate: ");
        double r = double.Parse(Console.ReadLine());

        Console.Write("Enter Time: ");
        double t = double.Parse(Console.ReadLine());

        double ci = p * Math.Pow((1 + r / 100), t);
        Console.WriteLine("Compound Interest = " + ci);
    }
}
