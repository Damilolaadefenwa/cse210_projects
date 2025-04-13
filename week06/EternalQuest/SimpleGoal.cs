using System;


public class SimpleGoal : Goal
{
    private bool _isComplete;

    // Constructor to initialize the simple goal variable members
    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
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

    // Create a getter method for the _isComplete variable
    public bool GetIsComplete()
    {
        return _isComplete;
    }

    // override the GetDetailsString method which also serve as display method
    public override void GetDetailsString()
    {
        Console.WriteLine($"SimpleGoal: {GetNames()}, ({GetPoints()}), -Complete: {_isComplete}");
    }

    // Override the GetstringRepresentation method to return a string representation a.k.a information of the goal
    public override string GetstringRepresentation()
    {
        return $"{(IsComplete() ? "[X]" : "[]")} {GetNames()}, ({GetDescription()}), -Point: {GetPoints()}";
    }

}