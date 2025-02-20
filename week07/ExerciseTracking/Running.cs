public class Running : Activity
{
    private double _distance;  // Distance in miles

    public Running(string date, int durationMinutes, double distance) : base(date, durationMinutes)
    {
        _distance = distance;
    }

    // Override GetDistance for running
    public override double GetDistance()
    {
        return _distance;  // Return the distance directly for running
    }

    // Override GetSpeed for running
    public override double GetSpeed()
    {
        return (_distance / _durationMinutes) * 60;  // Speed = distance / time * 60
    }

    // Override GetPace for running
    public override double GetPace()
    {
        return _durationMinutes / _distance;  // Pace = time / distance
    }
}
