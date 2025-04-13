using System;

public class EternalGoal : Goal
{

    // Has no member variables
    // Constructor to initialize the eternal goal variable members from the base class
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        // Has nothing to initialize
    }

    // Override the RecordEvent method to record the event for the eternal goal
    public override void RecordEvent()
    {
        // Eternal goals are never complete, so this method does nothing
    }

    // Override the IsComplete method to always return false for eternal goals
    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    // override the GetDetailsString method which also serve as display method
    public override string GetDetailsString()
    {
        return $"EternalGoal: {GetNames()}, ({GetDescription()}), -Point: {GetPoints()}"; // No completion status for eternal goals
        // Console.WriteLine($"[ ] {GetNames()} - Points: {GetPoints()}");
    }

    // Override the GetstringRepresentation method to return a string representation a.k.a information of the goal
    public override string GetstringRepresentation()
    {
        return $"EternalGoal:{(IsComplete() ? "[X]" : "[]")} {GetNames()}, ({GetDescription()}), -Point: {GetPoints()} "; // No completion status for eternal goals
    }
    

}