using System;

public abstract class Activity
{
    private DateTime _date;
    private int _durationMinutes;

    // Constructor that sets the date and duration for all activities
    public Activity(DateTime date, int durationMinutes)
    {
        _date = date;
        _durationMinutes = durationMinutes;
    }

    // Abstract methods that subclasses must implement to define how to get the distance, speed, and pace.
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // A method that returns a nice summary for the activity, calling the above methods for calculations
    public string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_durationMinutes} min) - Distance: {GetDistance()} {GetDistanceUnit()}, Speed: {GetSpeed()} {GetSpeedUnit()}, Pace: {GetPace()} {GetPaceUnit()}";
    }

    // Default units for distance, speed, and pace that can be overridden by subclasses
    protected virtual string GetDistanceUnit() => "miles";
    protected virtual string GetSpeedUnit() => "mph";
    protected virtual string GetPaceUnit() => "min per mile";
}

