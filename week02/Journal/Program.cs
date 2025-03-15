using System;

// To show creativity and exceed the requirements of the project, I'm updating the main program to include the prompts, 
// for the location and mood information.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Please select one of the following choice.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Load ");
            Console.WriteLine("4. Save ");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    // Generate, display and save a random prompt, and then write it to the journal.
                    string _promptText = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(_promptText);
                    myJournal.SavingPrompt(_promptText);
                    string entryText = Console.ReadLine();
                    Console.WriteLine("Tell us about your mood/emotion? ");
                    string mood = Console.ReadLine();
                    Console.WriteLine("Enter your location? ");
                    string location = Console.ReadLine();   
                    myJournal.AddEntry(entryText, mood, location);
                    Console.WriteLine("Your entry has been added.");
                    break;
                case "2":
                    Console.WriteLine("Here are all the journal entries:");
                    myJournal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter the file path to load entries: ");
                    string loadFilePath = Console.ReadLine();
                    myJournal.LoadFromFile(loadFilePath);
                    break;
                case "4":
                    Console.Write("Enter the file path to save entries: ");
                    string saveFilePath = Console.ReadLine();
                    myJournal.SaveToFile(saveFilePath);
                    break;    
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            
            }



        }


       
        






    }

    

   








}