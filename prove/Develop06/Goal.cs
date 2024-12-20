public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public int Points => _points;
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    public string GetDetails() => $"{_shortName}: {_description} ({_points} pts)";
}