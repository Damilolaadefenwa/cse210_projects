using System;
public class Journal
{
    // Initiating a variable member that handle the list of entries.
    private List<Entry> entries;
    // Initiating a variable member that handle the prompt generator.
    private PromptGenerator promptGenerator;

    // Making a new list of entries and a new prompt generator that can access by all.
    public Journal()
    {
        entries = new List<Entry>();
        promptGenerator = new PromptGenerator();
    }

    public void AddEntry(string entryText)
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Entry entry = new Entry(prompt, entryText);
        entries.Add(entry);

        //string prompt = promptGenerator.GetRandomPrompt();
        //Console.WriteLine(prompt);
        //string entryText = Console.ReadLine();
        //Entry entry = new Entry(prompt, entryText);
        //entries.Add(entry);

    }
    
    // This is a method. It's function is to display all the entries in the journal.
    public void DisplayAll()
    {
        // If there are no entries, display a message and return.
        // if (entries.Count == 0)
        // {
        //     Console.WriteLine("No entries to display.");
        //     return;
        // }
        
        // Loop through all the entries and display each one.
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }


    // New method to save entries to a text file
    //  public void SaveEntriesToFile(string filePath)
    // {
    //     try
    //     {
    //         using (StreamWriter writer = new StreamWriter(filePath))
    //         {
    //             foreach (var entry in entries)
    //             {
    //                 writer.WriteLine(entry.ToString());
    //                 writer.WriteLine("------------------------------");
    //             }
    //         }
    //         Console.WriteLine("Entries successfully saved to file.");
    //     }
    //     catch (Exception ex)
    //     {
    //         Console.WriteLine($"An error occurred while saving the entries: {ex.Message}");
    //     }
    // }

    



}