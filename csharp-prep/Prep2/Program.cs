using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        string letter = "";
        Console.WriteLine("");

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else if (number < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (number >= 70)
        {
            Console.WriteLine("You PASS the course.");
            Console.WriteLine("Congratulations !!.");
        }
        else if (number < 70)
        {
            Console.WriteLine("You FAIL the course.");
            Console.WriteLine("Be better the next time.");
        }
    }
}