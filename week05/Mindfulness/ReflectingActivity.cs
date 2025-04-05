using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    // Constructor that initializes the activity with a name, description, and duration.
    public ReflectingActivity(List<string> prompts, List<string> questions, string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    // Method to Run the Reflecting Activity.
    public void Run()
    {
        Console.WriteLine("Welcome to the Reflecting Activity!");
        Console.WriteLine("This activity will help you reflect on your thoughts and feelings.");
        Console.WriteLine("Press any key to begin...");
        Console.ReadKey();

        // Display a random prompt
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");

        // Display a random question
        string question = GetRandomQuestion();
        Console.WriteLine($"Question: {question}");

        // Wait for user input before ending the activity
        Console.WriteLine("Press any key to end the activity...");
        Console.ReadKey();
    }

    // Method to get a random prompt.
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    // Method to get a random question.
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
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