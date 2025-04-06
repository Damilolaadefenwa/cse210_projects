using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    // Constructor that initializes the activity with a name, description, and duration.
    public ListingActivity(int count, List<string> prompts) 
        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {
        _count = count;
           
        _prompts = prompts;
        // Default initialization of prompts if the list is empty.
        if (_prompts.Count == 0)
        {
            _prompts.Add("Who are people that you appreciate?");
            _prompts.Add("What are personal strengths of yours?");
            _prompts.Add("Who are people that you have helped this week?");
            _prompts.Add("When have you felt the Holy Ghost this month?");
            _prompts.Add("Who are some of your personal heroes?");
        }
    }

    // Method to Run the Listing Activity.
    public void Run()
    {
        // The activity should begin with the standard starting message and prompt for the 
        // duration that is used by all activities.
        DisplayStartMessage();

        // After the starting message, select a random prompt to show the user and display it for some time.
        // and the user should be encouraged to think about it during that time.
        
        Console.WriteLine("Get ready.....");
        ShowSpinner(7); // Show spinner for 7 seconds
        Console.WriteLine("List as many responses you can to the following prompt:");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"---- {prompt} ----");
        // After displaying the prompt, the program should give them a countdown of several seconds to 
        // begin thinking about the prompt.
        Console.WriteLine("You may begin in: "); ShowCountdown(7); // Show countdown for 7 seconds

        // Then, it should prompt them to keep listing items.
        //The user lists as many items as they can until they they reach the duration specified by 
        // the user at the beginning.
        GetListFromUser(); // Call the method to get a list from the user

        //The activity should conclude with the standard finishing message for all activities.
        DisplayEndMessage();

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
        Console.WriteLine("Please type 'done' to finish.");
        string input;
        while ((input = Console.ReadLine()) != "done")
        {
            _prompts.Add(input);
            _count++;
        }
        //The activity them displays back the number of items that were entered.
        Console.WriteLine($"You have listed {_count} items so far.");
        Console.WriteLine("Thank you for your input!");
    }
    

}

