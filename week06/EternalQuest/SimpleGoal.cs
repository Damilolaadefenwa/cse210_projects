using System;


public class SimpleGoal : Goal
{
    private bool _isComplete;

    // Constructor to initialize the simple goal variable members
    public SimpleGoal(string shortName, string description, string points) : base(shortName, description, points)
    {
        _isComplete = false;
    }

    // Override the RecordEvent method to mark the goal as complete.
    // such as marking a simple goal complete
    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true; // Mark the goal as complete
        }
    }

    // Override the IsComplete method to check if the goal is complete
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Override the GetstringRepresentation method to return a string representation of the goal
    public override string GetstringRepresentation()
    {
        return $"SimpleGoal: {GetDetailsString()}, -Complete: {_isComplete}";
    }

}