using System;
using System.Collections.Generic;

// To show creativity and exceed the requirements of the project, I have added other interesting information
// such as Mood and Location to get more information about the user's day.
// In this class, I'm going to update it with this information.

public class Entry
{
    private PromptGenerator promptGenerator;
    
    // Memory to store a specific prompt
    public string savedPrompt;

    // Initiating a variable member that handle the list of entries.
    public string _date; // is a variable member that handle date of the entry
    public string _promptText; // is a variable member that handle the text of the entry.
    public string _entryText; // is a variable member that handle the answer to text prompt of the entry

    // Exceeding the requirements of the project.
    public string _Mood; // New variable member that handle the mood of the user.
    public string _Location; // New variable member that handle the location of the user.  

    // This is a constructor. It is a special method I called when an object is created.
    public Entry(string promptText, string entryText, string mood, string location)
    {
        _date = DateTime.Now.ToString("MM/dd/yyyy");
        _promptText = promptText;
        _entryText = entryText;
        _Mood = mood;
        _Location = location;
    }
    
    // This is a method. It's function is to display the entry.
    public void Display()
    {
        Console.WriteLine($":Date: {_date} Prompt: {_promptText}\nEntry: {_entryText}\nMood: {_Mood}\nLocation: {_Location}");
    }

}