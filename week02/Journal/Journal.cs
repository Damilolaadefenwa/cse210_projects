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
    // // Memory to store a generated prompt
    // public  List<string> savedPrompt;

    // Making a new list of entries and a new prompt generator that can access by all.
    public Journal()
    {
        entries = new List<Entry>();
        promptGenerator = new PromptGenerator();
        // savedPrompt = new List<string>(); // Initialize the list of saved prompts

    }


    // This is a method. It's function is to add an entry to the journal.
    public void AddEntry(string entryText, string mood, string location)
    {
        string prompt = promptGenerator.GenerateRandomPrompt();
        Entry entry = new Entry(DateTime.Now.ToString("MM/dd/yyyy"), prompt, entryText, mood, location);
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
                    outputFile.WriteLine(entry._mood);
                    outputFile.WriteLine(entry._location);
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

    // Method to load entries from a file
    public void LoadFromFile(string filePath)
    {
        try
        {
            string[] lines = System.IO.File.ReadAllLines(filePath); // Use the provided filePath
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length == 5) // Check if the line has the expected number of parts
                {
                    string _date = parts[0];
                    string _promptText = parts[1];
                    string _entryText = parts[2];
                    string _mood = parts[3];
                    string _location = parts[4];

                    // Console.WriteLine($"Date: {_date} Prompt: {_promptText} Entry: {_entryText}");
                }
                else
                {
                    
                    Console.WriteLine($"'{filePath}': '{line}'");
                    // Console.WriteLine($"Warning:Invalid line format in file '{filePath}': '{line}'");
                }
            }
        }
        catch (System.IO.FileNotFoundException)
        {
            Console.WriteLine($"Error: File not found at '{filePath}'.");
        }
        catch (System.IO.IOException ex)
        {
            Console.WriteLine($"Error: An IO exception occured while trying to read the file '{filePath}': {ex.Message}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine($"Error: an index out of range exception occured while parsing the file '{filePath}'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }

}