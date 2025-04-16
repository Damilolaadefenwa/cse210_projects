using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        // Create an instance of ActivityTracker
        Console.WriteLine("------------------------------------------------------");
        // Create an instance of the ActivityTracker
        ActivityTracker mytracker = new ActivityTracker();

        try
        {
            // Create activity objects with sample data
            Activity running = new Running(DateTime.ParseExact("16/04/2025", "dd/MM/yyyy", CultureInfo.InvariantCulture), 30, 3.0);
            Activity bicycle = new StationaryBicycle(DateTime.ParseExact("16/04/2025", "dd/MM/yyyy", CultureInfo.InvariantCulture), 45, 20.0);
            Activity swimming = new Swimming(DateTime.ParseExact("16/04/2025", "dd/MM/yyyy", CultureInfo.InvariantCulture), 60, 30);

            // Add activities to the tracker
            Console.WriteLine("Adding the activities to the tracker...");
            mytracker.AddActivity(running);
            mytracker.AddActivity(bicycle);
            mytracker.AddActivity(swimming);

            // Display all activities
            Console.WriteLine();
            mytracker.DisplayActivities();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format. Please enter date in dd/mm/yyyy and numeric values for others.");
        }
        
        Console.WriteLine();

    }
}