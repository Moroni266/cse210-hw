using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop06 World!");

        GoalManager manager = new GoalManager();

        // Crear algunas metas de ejemplo
        manager.CreateGoal(new SimpleGoal("Run a Marathon", "Complete a 42K marathon", 1000));
        manager.CreateGoal(new EternalGoal("Read Scriptures", "Read scriptures every day", 100));
        manager.CreateGoal(new CheckListGoal("Attend Temple", "Attend the temple", 50, 10, 500));

        bool running = true;
        while (running)
        {
            Console.WriteLine("\n1. List Goals\n2. Record Event\n3. Display Score\n4. Save Goals\n5. Load Goals\n6. Quit");
            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    manager.ListGoals();
                    break;
                case "2":
                    Console.Write("Enter goal number: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordEvent(index);
                    break;
                case "3":
                    manager.DisplayScore();
                    break;
                case "4":
                    manager.SaveGoals("goals.txt");
                    break;
                case "5":
                    manager.LoadGoals("goals.txt");
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}