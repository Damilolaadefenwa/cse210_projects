using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public abstract class  Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    // Constructor to initialize the goal variable members
    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    // Create setters and getters for the goal variable members
    public string Getpoints()
    {
        return _points;
    }
    public void Setpoints(string points)
    {
        _points = points;
    }

    // Create some methods to be overridden in the derived classes.
    public abstract void RecordEvent();
    public abstract bool IsComplete();

    public string GetDetailsString()
    {
        return $"{_shortName} ({_description}) - Points: {_points}";
    }

    public abstract string GetstringRepresentation();
    
}