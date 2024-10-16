using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");
        Assignment _assignment = new Assignment("Samuel Benett", "Multiplication");
        Console.WriteLine(_assignment.GetSummary());
    }
}