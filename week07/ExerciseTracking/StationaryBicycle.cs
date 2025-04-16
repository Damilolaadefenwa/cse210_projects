using System;
using System.Collections.Generic;
using System.Globalization;

public class StationaryBicycle : Activity
{
    // Encapsulation: Private field for speed with public property for access
    // public double SpeedMph { get; private set; }
    private double _speedMph;
    // Constructor to initialize StationaryBicycle-specific properties
    public StationaryBicycle(DateTime date, int durationMinutes, double speedMph)
        : base(date, durationMinutes)
    {
        if (speedMph <= 0)
        {
            throw new ArgumentException("Speed must be greater than zero.");
        }
        _speedMph = speedMph;
    }

    // Implementation of abstract methods for StationaryBicycle
    public override double GetDistance()
    {
        // Calculate distance based on speed and duration
        return _speedMph / 60 * GetdurationMinutes(); // Distance in miles
    }

    public override double GetSpeed() => _speedMph; // Returns stored speed

    public override double GetPace()
    {
        // Calculate pace in minutes per mile.  Avoid division by zero.
        return _speedMph > 0 ? 60 / _speedMph : 0;
    }

    public override string GetSummary()
    {
        // Format the date
        string formattedDate = GetDate().ToString("dd MMM yyyy", CultureInfo.InvariantCulture);
        // Return the summary string
        return $"{formattedDate} Stationary Bicycle ({GetdurationMinutes()} min) - Distance {GetDistance():F1} miles, Speed {_speedMph}:mph, Pace: {GetPace():F1} min per mile";
    }
}
