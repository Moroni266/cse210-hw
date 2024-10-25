public class EternalGoal : Goal
{
    private int _timesCompleted;
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _timesCompleted = 0;
    }

    public override void RecordEvent()
    {
        _timesCompleted++;
    }

    public override bool IsComplete() => false;

    public override string GetStringRepresentation()
    {
        return $"[∞] {GetDetails()} - Completed {_timesCompleted} times";
    }


}