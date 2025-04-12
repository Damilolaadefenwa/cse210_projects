using System;

public class EternalGoal : Goal
{

    // Has no member variables
    // Constructor to initialize the eternal goal variable members from the base class
    public EternalGoal(string shortName, string description, string points) : base(shortName, description, points)
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

    // Override the GetstringRepresentation method to return a string representation of the eternal goal
    public override string GetstringRepresentation()
    {
        return $"EternalGoal: {GetDetailsString()}"; // No completion status for eternal goals
    }
    

}