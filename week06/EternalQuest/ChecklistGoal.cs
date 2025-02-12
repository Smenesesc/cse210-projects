public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _timesCompleted++;
        int totalPoints = _points;
        if (_timesCompleted == _target)
        {
            totalPoints += _bonus;
            Console.WriteLine($"Congratulations! You completed the goal {_shortName} { _target } times! Bonus points awarded: {_bonus}");
        }
        Console.WriteLine($"You earned {totalPoints} points for completing the goal: {_shortName}. Total completed: {_timesCompleted}/{_target}");
    }

    public override bool IsComplete()
    {
        return _timesCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return IsComplete() ? $"[X] {_shortName}: {_description} (Completed {_timesCompleted}/{_target})" : $"[ ] {_shortName}: {_description} (Completed {_timesCompleted}/{_target})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_timesCompleted}";
    }
}

