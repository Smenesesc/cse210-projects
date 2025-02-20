public abstract class Activity
{
    protected string _date;  // Date of the activity
    protected int _durationMinutes;  // Duration in minutes

    public Activity(string date, int durationMinutes)
    {
        _date = date;
        _durationMinutes = durationMinutes;
    }

    // Abstract methods to be implemented by derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Method to return the summary for the activity
    public string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_durationMinutes} min) - Distance {GetDistance()}, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
