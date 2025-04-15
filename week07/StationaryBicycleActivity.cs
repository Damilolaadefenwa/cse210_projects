using System;
using System.Collections.Generic;
using System.Globalization;

// Inheritance: Derived class for StationaryBicycle activity
public class StationaryBicycle : Activity
{
    // Encapsulation: Private field for speed with public property for access
    public double SpeedMph { get; private set; }

    // Constructor to initialize StationaryBicycle-specific properties
    public StationaryBicycle(DateTime date, int durationMinutes, double speedMph)
        : base(date, durationMinutes)
    {
        if (speedMph <= 0)
        {
            throw new ArgumentException("Speed must be greater than zero.");
        }
        SpeedMph = speedMph;
    }

    // Implementation of abstract methods for StationaryBicycle
    public override double GetDistance()
    {
        // Calculate distance based on speed and duration
        return SpeedMph / 60 * DurationMinutes;
    }

    public override double GetSpeed() => SpeedMph; // Returns stored speed

    public override double GetPace()
    {
        // Calculate pace in minutes per mile.  Avoid division by zero.
        return SpeedMph > 0 ? 60 / SpeedMph : 0;
    }

    public override string GetSummary()
    {
        // Format the date
        string formattedDate = Date.ToString("dd MMM yyyy", CultureInfo.InvariantCulture);
        // Return the summary string
        return $"{formattedDate} Stationary Bicycle ({DurationMinutes} min) - Distance {GetDistance():F1} miles, Speed {SpeedMph:F1} mph, Pace: {GetPace():F1} min per mile";
    }
}
