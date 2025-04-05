using System;
using System.Threading;

public class BreathingActivity : Activity
{
    // Constructor that initializes the activity with a name, description, and duration.
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        
        // Initialize the BreathingActivity with default values.
        // You can customize the name, description, and duration as needed.
        name = "Breathing Exedrcise";
        description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    }

    public void Run()
    {
        DisplayStartMessage();
        Console.WriteLine("Get ready to begin in 3.....");
        ShowSpinner(5);
        Console.WriteLine("Breathe in... 1... 2... 3... 4...");
        ShowCountdown(4);
        Console.WriteLine("Pause for 4 seconds...");
        
        ShowSpinner(5);
        Console.WriteLine("Breathe out... 1... 2... 3... 4...");
        ShowCountdown(4);
        Console.WriteLine("Pause for 4 seconds...");

        DisplayEndMessage();
        Console.WriteLine("Thank you for participating in the Breathing Activity.");
    }

}

