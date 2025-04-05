using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    // Constructor that initializes the activity with a name, description, and duration.
    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _count = 0;
        _prompts = new List<string>();
    }
    
    // Method get a random prompts.
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    // Method to get List from the user.
    public void GetListFromUser()
    {
        Console.WriteLine("Please enter a list of items (type 'done' to finish):");
        string input;
        while ((input = Console.ReadLine()) != "done")
        {
            _prompts.Add(input);
            _count++;
        }
    }



}

