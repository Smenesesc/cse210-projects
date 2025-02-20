using System;

public class Running : Activity
{
    private double _distance; // Distance in miles

    public Running(DateTime date, int durationMinutes, double distance) : base(date, durationMinutes)
    {
        _distance = distance; // Set the distance for this running activity
    }

    // Overriding the methods to calculate running-specific distance, speed, and pace
    public override double GetDistance() => _distance;
    public override double GetSpeed() => (_distance / base._durationMinutes) * 60; // Speed = distance / time * 60
    public override double GetPace() => base._durationMinutes / _distance; // Pace = time / distance

    // Customizing the units specifically for running
    protected override string GetDistanceUnit() => "miles";
    protected override string GetSpeedUnit() => "mph";
    protected override string GetPaceUnit() => "min per mile";
}
