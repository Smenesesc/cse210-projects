using System;

public class Cycling : Activity
{
    private double _speed; // Speed in miles per hour

    public Cycling(DateTime date, int durationMinutes, double speed) : base(date, durationMinutes)
    {
        _speed = speed; // Set the speed for this cycling activity
    }

    // Overriding methods for cycling-specific calculations
    public override double GetDistance() => _speed * base._durationMinutes / 60; // Distance = speed * time / 60
    public override double GetSpeed() => _speed; // Just return the speed directly
    public override double GetPace() => 60 / _speed; // Pace = 60 / speed

    // Customizing the units for cycling
    protected override string GetDistanceUnit() => "miles";
    protected override string GetSpeedUnit() => "mph";
    protected override string GetPaceUnit() => "min per mile";
}
