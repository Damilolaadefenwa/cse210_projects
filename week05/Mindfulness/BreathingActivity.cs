using System;
using System.Threading;

public class BreathingActivity : Activity
{
    // Constructor that initializes the activity with a name, description, and duration.
    public BreathingActivity(int duration) 
        : base("Breathing Exercise", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0, null)
    {
        // A Constructor initializes the BreathingActivity with default values.
    }

    public void Run()
    {
        DisplayStartMessage();
        Console.WriteLine("Get ready to begin in 3.....");
        Console.WriteLine("Breathe in.................");
        ShowSpinner(6);
        Thread.Sleep(1000);
        ShowCountdown(6);
        
        Console.WriteLine("Breathe out..............");
        ShowSpinner(6);
        Thread.Sleep(1000);
        ShowCountdown(6);


        DisplayEndMessage();
        Console.WriteLine("Thank you for participating.");

        IncrementActivityCount(); // Increment the activity count for this activity
    }

}

