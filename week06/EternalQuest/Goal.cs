using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();  // Abstract method to record event

    public abstract bool IsComplete();   // Abstract method to check if the goal is complete

    public virtual string GetDetailsString()
    {
        return $"[ ] {_shortName}: {_description}";
    }

    public abstract string GetStringRepresentation();
}
