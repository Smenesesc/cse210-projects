public class Cycling : Activity
{
    private double _speed;  // Speed in miles per hour

    public Cycling(string date, int durationMinutes, double speed) : base(date, durationMinutes)
    {
        _speed = speed;
    }

    // Override GetDistance for cycling
    public override double GetDistance()
    {
        return (_speed * _durationMinutes) / 60;  // Distance = speed * time / 60
    }

    // Override GetSpeed for cycling
    public override double GetSpeed()
    {
        return _speed;  // Return the speed directly for cycling
    }

    // Override GetPace for cycling
    public override double GetPace()
    {
        return 60 / _speed;  // Pace = 60 / speed
    }
}
