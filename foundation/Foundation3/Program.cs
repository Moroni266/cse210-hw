using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");
        var running = new Running(new DateTime(2024, 10, 29), 30, 4.8);
        var cycling = new Cycling(new DateTime(2024, 10, 29), 40, 20);
        var swimming = new Swimming(new DateTime(2024, 10, 29), 25, 30);

        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}