using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;

    private List<string> _questions;

    // Default constructor that initializes the activity with default prompts and questions.
    public ReflectingActivity(List<string> prompt, List<string> questions) 
        : base("Reflecting","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0)
    {
        // Default initialization of prompts and questions
        // set default values for the prompts and questions.

        _prompts = prompt;
        if (_prompts.Count == 0)
        {
            _prompts.Add("Think of a time when you stood up for someone else.");
            _prompts.Add("Think of a time when you did something really difficult.");
            _prompts.Add("Think of a time when you helped someone in need.");
            _prompts.Add("Think of a time when you did something truly selfless.");
            _prompts.Add("Think of a time when you learned something new.");
            _prompts.Add("Think of a time when you overcame a challenge.");
            _prompts.Add("Think of a time when you made a difference in someone's life.");
        }
        // Initialize the questions list with default values if it is empty.
        _questions = questions;
        if (_questions.Count == 0)
        {
            _questions.Add("What did you learn from this experience?");
            _questions.Add("How did you feel during this experience?");
            _questions.Add("What was the most challenging part of this experience?");
            _questions.Add("How did you overcome the challenges you faced?");
            _questions.Add("What would you do differently if you could do it again?");
            _questions.Add("What advice would you give to someone facing a similar situation?");
            _questions.Add("How can you apply what you've learned to future situations?");
        }
        
    }

    // Method to Run the Reflecting Activity.
    public void Run()
    {
        //The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
        DisplayStartMessage();
        
        Console.WriteLine("Get ready.....");
        ShowSpinner(3); // Show spinner for 3 seconds
        Console.WriteLine("Consider the following prompt:");

        // After the starting message, select a random prompt to show the user and display it.
        // The prompt should be displayed for 7 seconds, and the user should be encouraged to think about it during that time.
        // Display a random prompt

        string prompt = GetRandomPrompt();
        Console.WriteLine($"-------: {prompt}.-------");
        // Wait for user input before you proceed to the next step.
        Console.WriteLine("When you have something in mind, press enter to continue...");
        Console.ReadKey();

        // Display a random question to the user and encourage them to think about it for 7 seconds.
        // The question should be displayed for 7 seconds, and the user should be encouraged to think about it during that time.
        
        Console.WriteLine("Now, ponder on each of the following questions that relate to this experience:");
        string question = GetRandomQuestion();
        Console.WriteLine();
        Console.WriteLine($"> {question}");
        Console.WriteLine($"You may begin in.......");
        ShowSpinner(15); // Show animation for 15 seconds
        Console.WriteLine();
        Console.WriteLine("> How did you feel when it was complete?.");
        ShowSpinner(15); // Show spinner for 7 seconds
        Console.WriteLine($"> {question}");
        ShowSpinner(15); // Show spinner for 15 seconds
        ShowCountdown(7); // Show countdown for 7 seconds
        
        DisplayEndMessage();
        ShowSpinner(15); // Show spinner for 15 seconds
        Console.WriteLine("Thank you for participating.");

        // // Wait for user input before ending the activity
        // Console.WriteLine("Press any key to end the activity...");
        // Console.ReadKey();
    }

    private static Random _random = new Random();

    // Method to get a random prompt.
    public string GetRandomPrompt()
    {
        // Randomly select a prompt from the list of prompts.
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
        
    }

    // Method to get a random question.
    public string GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count);
        return _questions[index];
    }

    // Method to display the prompts
    public void DisplayPrompts()
    {
        Console.WriteLine("Prompts:");
        foreach (string prompt in _prompts)
        {
            Console.WriteLine($"- {prompt}");
        }
    }
    // Method to display the questions
    public void DisplayQuestions()
    {
        Console.WriteLine("Questions:");
        foreach (string question in _questions)
        {
            Console.WriteLine($"- {question}");
        }
    }


}