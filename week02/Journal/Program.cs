using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal myJournal = new Journal();

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Add a new journal entry");
            Console.WriteLine("2. Display all journal entries");
            Console.WriteLine("3. Exit");
            // Console.WriteLine("");

            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine("Write your journal entry:");
                    string entryText = Console.ReadLine();
                    myJournal.AddEntry(entryText);
                    Console.WriteLine("Journal entry has been added.");
                    break;
                case "2":
                    Console.WriteLine("Here are all the journal entries:");
                    myJournal.DisplayAll();
                    break;
                case "3":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }



        }


       
        






    }

    

   








}