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
    public string GetNames()
    {
        return _shortName;
    }
    public void SetNames(string shortName)
    {
        _shortName = shortName;
    }

    // Create some methods to be overridden in the derived classes.

    // 1.The RecordEvent method is called when a goal has been accomplished another time.   
    public abstract void RecordEvent();

    // The IsComplete method checks if the goal is complete
    // This method should return true if the goal is completed. 
    // The way you determine if a goal is complete is different for each type of goal.
    public abstract bool IsComplete();

    // The GetDetailsString method returns a string representation of the goal details
    // This method should return the details of a goal that could be shown in a list. 
    // It should include the checkbox, the short name, and description
    public virtual string GetDetailsString()
    {
        return $"{(IsComplete() ? "[X]" : "[]")} {_shortName}, ({_description}), -Point: {_points}";
    }
    // The GetstringRepresentation method returns a string representation of the goal
    // This method should provide all of the details of a goal in a way that is easy 
    // to save to a file, and then load later.
    public abstract string GetstringRepresentation();
    
}