using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    //A Constructor that takes no parameters and initializes the activity with default values. 
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    
    // Create a getter for the name, description, and duration properties.
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }

    // Create the behaviour / methods function for the activity class.
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine(_description);
        _duration = 0;
        Console.WriteLine("How long, in seconds, would you like your session?");
        string input = Console.ReadLine();
        _duration = int.Parse(input);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine($"Well done!!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity.");
        
    }

    // Method to display the spinner for a given number of seconds.
    ////This method Pausing while showing a spinner for a certain number of seconds
    // and simulating loading time.
    // It takes an integer parameter seconds, which specifies the duration of the spinner.
    public void  ShowSpinner(int seconds)
    {
        Console.WriteLine("");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("\b/-/ \b"); // Show spinner character
            Thread.Sleep(1000); // Simulate loading time
            // Console.Write("\b \b"); // Erase the last character
        }
        Console.WriteLine();
    }
    
    // Method to display a countdown from a given number of seconds.
    // This method simulates a countdown timer by printing the remaining seconds to the console.
        public void ShowCountdown(int seconds)
    {
        Console.WriteLine("Countdown:");
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000); // Simulate countdown time
           
        }
        Console.WriteLine();
    }
    



}