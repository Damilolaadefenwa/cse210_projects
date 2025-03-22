using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Console.WriteLine("--------------------------------------------");

        string _reference = "John 3:16";
        string _text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life";

        Scripture scripture = new Scripture(_reference, _text);

        scripture.GetDisplayText();

        while (true)
        {
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
            scripture.GetDisplayText();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }
        }

        Console.WriteLine("\nAll words hidden. Program ended.");
        
    }
}