public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetStringRepresentation()
    {
        return IsComplete()
            ? $"[X] {GetDetails()} - Completed {_amountCompleted}/{_target} times (Bonus: {_bonus} pts)"
            : $"[ ] {GetDetails()} - Completed {_amountCompleted}/{_target} times";
    }

    public int GetTotalPoints()
    {
        return IsComplete() ? _points + _bonus : _points;
    }

}