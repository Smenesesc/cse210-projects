using System;

public class Swimming : Activity
{
    private int _laps; // Number of laps swum

    public Swimming(DateTime date, int durationMinutes, int laps) : base(date, durationMinutes)
    {
        _laps = laps; // Set the number of laps for this swimming activity
    }

    // Overriding methods for swimming-specific calculations
    public override double GetDistance() => _laps * 50 / 1000.0 * 0.62; // Convert laps to miles
    public override double GetSpeed() => (GetDistance() / base._durationMinutes) * 60; // Speed = distance / time * 60
    public override double GetPace() => base._durationMinutes / GetDistance(); // Pace = time / distance

    // Customizing the units for swimming
    protected override string GetDistanceUnit() => "miles";
    protected override string GetSpeedUnit() => "mph";
    protected override string GetPaceUnit() => "min per mile";
}
