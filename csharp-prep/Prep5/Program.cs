using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");
        WelcomeMessage();
        string user_name = UserName();
        int user_number = UserNumber();
        int squared_number = SquaredNumber(user_number);
        DisplayResult(user_name, squared_number);
    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string UserName()
    {
        Console.Write("Please enter your name: ");
        string user_name = Console.ReadLine();
        return user_name;
    }

    static int UserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string fav_number = Console.ReadLine();
        int user_number = int.Parse(fav_number);
        return user_number;
    }

    static int SquaredNumber(int number)
    {
        double squared_number = Math.Pow(number, 2);
        int squared = (int)squared_number;
        return squared;
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}