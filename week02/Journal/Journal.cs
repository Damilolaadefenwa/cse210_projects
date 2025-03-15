using System;
using System.Collections.Generic;
using System.IO;

// To show creativity and exceed the requirements of the project, I'm updating the AddEntry method of this class, 
// location, mood, reflection information.
public class Journal
{
    // Initiating a variable member that handle the list of entries.
    private List<Entry> entries;
    // Initiating a variable member that handle the prompt generator.
    private PromptGenerator promptGenerator;
    // Memory to store a generated prompt
    public  List<string> savedPrompt;

    // Making a new list of entries and a new prompt generator that can access by all.
    public Journal()
    {
        entries = new List<Entry>();
        promptGenerator = new PromptGenerator();
        savedPrompt = new List<string>(); // Initialize the list of saved prompts

    }

    // New method to save a prompt to the list of saved prompts
    public void savingPrompt( string promptText)
    {
        string _promptText = promptGenerator.GetRandomPrompt();
        savedPrompt.Add(_promptText);
    }

    // This is a method. It's function is to add an entry to the journal.
    public void AddEntry(string entryText, string mood, string location)
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Entry entry = new Entry(prompt, entryText, mood, location);
        entries.Add(entry);

    }
    
    // This is a method. It's function is to display all the entries in the journal.
    public void DisplayAll()
    {
        // If there are no entries, display a message and return.
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }
        // Loop through all the entries and display each one.
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    // New method to save entries to a text file
     public void SaveToFile(string filePath)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(filePath))
            {
                foreach (var entry in entries)
                {
                    //adding text to the file with the WriteLine method
                    outputFile.WriteLine(entry._date);
                    outputFile.WriteLine(entry._promptText);
                    outputFile.WriteLine(entry._entryText);
                    outputFile.WriteLine("---"); // Separator for each entry
                }
            }
            Console.WriteLine("Entries successfully saved to file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving the entries: {ex.Message}");
        }
    }

    // New method to load entries from a text file
    public void LoadFromFile(string filePath)
    {
        try
        {
            using (StreamReader inputFile = new StreamReader(filePath))
            {
                while (!inputFile.EndOfStream)
                {
                    string date = inputFile.ReadLine();
                    string prompt = inputFile.ReadLine();
                    string entryText = inputFile.ReadLine();
                    string separator = inputFile.ReadLine(); // Read the separator line

                    // Create a new entry and add it to the list
                    Entry entry = new Entry(prompt, entryText, "", "");
                    entry._date = date;
                    entries.Add(entry);
                }
            }
            Console.WriteLine("Entries successfully loaded from file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading the entries: {ex.Message}");
        }

    }  


}