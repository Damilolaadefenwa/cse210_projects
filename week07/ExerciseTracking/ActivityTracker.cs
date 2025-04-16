using System;
using System.Collections.Generic;
using System.Globalization;

// Class to manage a collection of activities
public class ActivityTracker
{
    // Encapsulation: Private field for the list of activities
    private List<Activity> activitiesList;

    // Constructor to initialize the list
    public ActivityTracker()
    {
        activitiesList = new List<Activity>();
    }

    // Method to add an activity to the list
    public void AddActivity(Activity activity)
    {
        activitiesList.Add(activity);
        Console.WriteLine("Activity added successfully.");
    }

    // Method to display all activities
    public void DisplayActivities()
    {
        if (activitiesList.Count == 0)
        {
            Console.WriteLine("No activities recorded yet.");
            return;
        }
        Console.WriteLine("Activity Log:");
        foreach (var activity in activitiesList)
        {
            Console.WriteLine(activity.GetSummary()); // Polymorphism: Calls the correct GetSummary() method
        }
    }
}