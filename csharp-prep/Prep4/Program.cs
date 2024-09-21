using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        bool flag = false;
        int totalSum = 0;

        do
        {
            Console.Write("Enter number: ");
            string user_number = Console.ReadLine();
            int entry_number = int.Parse(user_number);
            numbers.Add(entry_number);

            if (entry_number == 0)
            {
                flag = true;
            }
        } while (flag == false);

        foreach (int num in numbers)
        {
            totalSum = totalSum + num;
        }

        double average = numbers.Average();
        int max_number = numbers.Max();
        Console.WriteLine($"The sum is: {totalSum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max_number}");
    }
}