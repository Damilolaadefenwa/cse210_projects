using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts; // is a variable member that handle the list of prompts

    //// Initialize the list with some predefined prompts
    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What did you do today?",
            "What are you grateful for today?",
            "What are you looking forward to tomorrow?",
            "Are you grateful to heavenly father for today?",
            "What did you struggle with today?",
            "What are you proud of today?",
            
        };
    }

    // Method to generate a random word and save it to the list of prompts
    public string GenerateRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        _prompts.Add(_prompts[index]);
        return _prompts[index];
        
    }

    // Get a random prompt from the list
    // public string GetRandomPrompt()
    // {
    //     Random random = new Random();
    //     int index = random.Next(_prompts.Count);
    //     return _prompts[index];
    // }



}