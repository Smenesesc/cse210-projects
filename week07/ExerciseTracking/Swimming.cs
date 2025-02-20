public class Swimming : Activity
{
    private int _laps;  // Number of laps

    public Swimming(string date, int durationMinutes, int laps) : base(date, durationMinutes)
    {
        _laps = laps;
    }

    // Override GetDistance for swimming
    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0 * 0.62;  // Convert laps to miles (50m per lap)
    }

    // Override GetSpeed for swimming
    public override double GetSpeed()
    {
        return (GetDistance() / _durationMinutes) * 60;  // Speed = distance / time * 60
    }

    // Override GetPace for swimming
    public override double GetPace()
    {
        return _durationMinutes / GetDistance();  // Pace = time / distance
    }
}
