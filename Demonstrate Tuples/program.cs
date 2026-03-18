using System;

class Program
{
    static void Main()
    {
        var student = (Id: 1, Name: "Vedant", Age: 21);

        Console.WriteLine("ID: " + student.Id);
        Console.WriteLine("Name: " + student.Name);
        Console.WriteLine("Age: " + student.Age);
    }
}
