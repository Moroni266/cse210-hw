using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");
        Assignment _assignment = new Assignment("Samuel Benett", "Multiplication");
        Console.WriteLine(_assignment.GetSummary());

        MathAssignment _assignment2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(_assignment2.GetSummary());
        Console.WriteLine(_assignment2.GetHomeworkList());

        WritingAssignment _assignment3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(_assignment3.GetSummary());
        Console.WriteLine(_assignment3.GetWritingInformation());
    }
}