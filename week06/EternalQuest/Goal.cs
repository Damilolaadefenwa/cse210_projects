using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public abstract class  Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    // Constructor to initialize the goal variable members
    public Goal(string shortName, string description, int points)
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
    public int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    
    // Create some methods to be overridden in the derived classes.

    // 1.The RecordEvent method is called when a goal has been accomplished another time.   
    // For example, it could be used to mark a simple goal as complete, or to increment the 
    // number of times a checklist goal has been completed.
    public abstract void RecordEvent();

    // The IsComplete method checks if the goal is complete
    // This method should return true if the goal is completed. 
    // The way you determine if a goal is complete is different for each type of goal.
    public abstract bool IsComplete();

    // The GetDetailsString method returns a string representation of the goal details
    // This method should return the details of a goal that could be shown in a list. 
    // It should include the checkbox, the short name, and description
    
    // public abstract void GetDetailsString();

    public virtual string GetDetailsString()
    {
        return $"{_shortName} ({_description}) -Points {_points}";
        // return $"{(IsComplete() ? "[X]" : "[]")} {_shortName}, ({_description}), -Point: {_points}";
    }
    
    // The GetstringRepresentation method returns a string representation of the goal
    // This method should provide all of the details of a goal in a way that is easy 
    // to save to a file, and then load later.
    // This is the version of DisplayGoalDetails();
    public abstract string GetstringRepresentation();


    
}