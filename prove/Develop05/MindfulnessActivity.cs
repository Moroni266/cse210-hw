abstract class MindfulnessActivity
{
    protected int duration;

    public void RunActivity()
    {
        DisplayStartMessage();
        PerformActivity();
        DisplayEndMessage();
    }

    protected virtual void DisplayStartMessage()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);
    }

    protected abstract void PerformActivity();

    protected virtual void DisplayEndMessage()
    {
        Console.WriteLine($"Good job! You've completed the activity for {duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }
}