using System;
using System.Collections.Generic;
using System.Globalization;

public class Running : Activity
{
    // Encapsulation: Private field for distance with public property for access
    // public double DistanceMiles { get; private set; }
    private double _distanceMiles;

    // Constructor to initialize Running-specific properties
    public Running(DateTime date, int durationMinutes, double distanceMiles)
        : base(date, durationMinutes)
    {
        if (distanceMiles <= 0)
        {
            throw new ArgumentException("Distance must be greater than zero.");
        }
        _distanceMiles = distanceMiles;
    }

    // Implementation of abstract methods for Running
    public override double GetDistance() => _distanceMiles;  // Returns stored distance

    public override double GetSpeed()
    {
        // Calculate speed in miles per hour
        return _distanceMiles / GetdurationMinutes() * 60;
    }

    public override double GetPace()
    {
        // Calculate pace in minutes per mile
        return GetdurationMinutes() / _distanceMiles;
    }

    public override string GetSummary()
    {
        // Format the date
        string formattedDate = GetDate().ToString("dd MMM yyyy", CultureInfo.InvariantCulture);
        // Return the summary string
        return $"{formattedDate} Running ({GetdurationMinutes()} min) - Distance {_distanceMiles}: miles, Speed {GetSpeed()}: mph, Pace: {GetPace()}: min per mile";
        // return $"{formattedDate} Running ({DurationMinutes} min) - Distance {DistanceMiles:F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}