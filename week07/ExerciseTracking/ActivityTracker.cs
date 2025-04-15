using System;
using System.Collections.Generic;
using System.Globalization;

// Class to manage a collection of activities
public class ActivityTracker
{
    // Encapsulation: Private field for the list of activities
    private List<Activity> activities;

    // Constructor to initialize the list
    public ActivityTracker()
    {
        activities = new List<Activity>();
    }

    // Method to add an activity to the list
    public void AddActivity(Activity activity)
    {
        activities.Add(activity);
        Console.WriteLine("Activity added successfully.");
    }

    // Method to display all activities
    public void DisplayActivities()
    {
        if (activities.Count == 0)
        {
            Console.WriteLine("No activities recorded yet.");
            return;
        }
        Console.WriteLine("Activity Log:");
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary()); // Polymorphism: Calls the correct GetSummary() method
        }
    }
}