using System;
using System.Collections.Generic;

Console.Write("Enter number of terms: ");
string? input = Console.ReadLine();

if (!int.TryParse(input, out int terms) || terms < 0)
{
    Console.WriteLine("Please enter a non-negative integer.");
    return;
}

List<long> series = new List<long>(Math.Max(terms, 0));
long a = 0;
long b = 1;

for (int i = 0; i < terms; i++)
{
    series.Add(a);
    long next = a + b;
    a = b;
    b = next;
}

Console.WriteLine("Fibonacci series:");
Console.WriteLine(terms == 0 ? "(empty)" : string.Join(" ", series));
