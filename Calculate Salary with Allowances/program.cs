using System;

class Program
{
    static void Main()
    {
        double basic, hra, da, total;

        Console.Write("Enter Basic Salary: ");
        basic = Convert.ToDouble(Console.ReadLine());

        hra = 0.2 * basic; // 20%
        da = 0.1 * basic;  // 10%

        total = basic + hra + da;

        Console.WriteLine("HRA = " + hra);
        Console.WriteLine("DA = " + da);
        Console.WriteLine("Total Salary = " + total);
    }
}
