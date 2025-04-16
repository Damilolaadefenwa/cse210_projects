using System;
using System.Collections.Generic;
using System.Globalization;

// Inheritance: Derived class for Swimming activity
public class Swimming : Activity
{
    // Encapsulation: Private field for laps with public property for access
    private int _laps;
    private const double MetersPerLap = 50; // Assume a standard 50-meter pool

    // Constructor to initialize Swimming-specific properties
    public Swimming(DateTime date, int durationMinutes, int laps)
        : base(date, durationMinutes)
    {
        if (laps <= 0)
        {
            throw new ArgumentException("Laps must be greater than zero.");
        }
        _laps = laps;
    }

    // Implementation of abstract methods for Swimming
    public override double GetDistance()
    {
        // Calculate distance in meters
        return _laps * MetersPerLap;
    }

    public override double GetSpeed()
    {
        // Calculate speed in meters per minute
        double distanceMeters = GetDistance();
        return distanceMeters / GetdurationMinutes(); // Speed in meters per minute
    }

    public override double GetPace()
    {
        // Pace is usually expressed as time per distance (e.g., minutes per 100m)
        double speedMetersPerMinute = GetSpeed();
        return speedMetersPerMinute > 0 ? 100 / speedMetersPerMinute : 0;
    }

    public override string GetSummary()
    {
        // Format the date
        string formattedDate = GetDate().ToString("dd MMM yyyy", CultureInfo.InvariantCulture);
        // Return the summary string
        return $"{formattedDate} Swimming ({GetdurationMinutes()} min) - Distance {GetDistance():F1} meters, Speed {GetSpeed():F1} m/min, Pace: {GetPace():F1} min per 100m";
    }
}