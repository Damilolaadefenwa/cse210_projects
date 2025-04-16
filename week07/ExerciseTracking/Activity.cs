using System;
using System.Collections.Generic;
using System.Globalization;

// Abstraction: Abstract class defining common properties and methods for all activities
public abstract class Activity
{
    // Encapsulation: Private fields with public properties for controlled access
    private DateTime _date;
    private int _durationMinutes;

    // Constructor to initialize common properties
    protected Activity(DateTime date, int durationMinutes)
    {
        _date = date;
        _durationMinutes = durationMinutes;
    }

    // Create some getter and setter methods for the private fields
    public int GetdurationMinutes()
    {
        return _durationMinutes;
    }
    public DateTime GetDate()
    {
        return _date;
    }
    
    // Abstract methods to be implemented by derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();

    //Method to prevent negative values for the inputs
    protected void ValidateInput(int durationMinutes)
    {
        if (durationMinutes <= 0)
        {
            throw new ArgumentException("Duration must be greater than zero.");
        }
    }
}