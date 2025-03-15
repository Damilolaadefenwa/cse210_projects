using System;
using System.Collections.Generic;


public class Entry
{
    public string _date; // is a variable member that handle date of the entry
    public string _promptText; // is a variable member that handle the text of the entry.
    public string _entryText; // is a variable member that handle the answer to text prompt of the entry

    // This is a constructor. It is a special method that is called when an object is created.
    public Entry(string promptText, string entryText)
    {
        _date = DateTime.Now.ToString("MM/dd/yyyy");
        _promptText = promptText;
        _entryText = entryText;
    }
    
    // This is a method. It's function is to display the entry.
    public void Display()
    {
        Console.WriteLine($":Date: {_date} Prompt: {_promptText}\nEntry: {_entryText}\n");
    }

    //  public override string ToString()
    // {
    //     return $"[{_date}] Prompt: {_promptText}\nEntry: {_entryText}\n";
    // }

    // public void Display()
    // {
    //     _date = "01/01/2022";
    //     _promptText = "What did you do today?";
    //     Console.WriteLine($"Date: {_date}");
    //     Console.WriteLine($"Prompt: {_promptText}");
    //     _entryText = Console.ReadLine();

    //     Console.WriteLine($"Entry: {_entryText}");
    // }


}