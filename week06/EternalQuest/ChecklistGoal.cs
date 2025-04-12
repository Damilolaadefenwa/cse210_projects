using System;
using System.Drawing;

public class ChecklistGoal : Goal
{

    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Constructor to initialize the checklist goal variable members
    public ChecklistGoal(string shortName, string description, string points, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // Override the RecordEvent method to increment the amount completed and check for bonus points
    //such adding to the number of times a checklist goal has been completed.
    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            if (_amountCompleted == _target)
            {
                IsComplete();      // Check if the goal is completes
                _amountCompleted += _bonus;    // Add bonus points when the target is reached
            }
        }   
        
    }

    // Override the IsComplete method to check if the goal is complete
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // Override the GetDetailsString method to shown the number of times the goal has been accomplished so far.
    // Then in the case of the ChecklistGoal class, it should be overridden to shown the number of times the 
    // goal has been accomplished so far.
    public override string GetDetailsString()
    {
        return $"ChecklistGoal: {base.GetDetailsString()}, -Completed: {_amountCompleted}/{_target}";
    }
    
    // Override the GetstringRepresentation method to return a string representation of the checklist goal
    public override string GetstringRepresentation()
    {
        return $"ChecklistGoal: {GetDetailsString()}, -Bonus: {_bonus}";
    }

}
