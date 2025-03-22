using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Console.WriteLine("--------------------------------------------");

        // string _reference = "John 3:16-17";
        // string _text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.For God sent not his Son into the world to condemn the world; but that the world through him might be saved.";

        // Scripture scripture = new Scripture(_reference, _text);


        //EXCEEDING REQUIREMENT:
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture("John 3:16-17", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life. For God sent not his Son into the world to condemn the world; but that the world through him might be saved."),
            new Scripture("Proverbs 3:5-6", "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
            new Scripture("Psalm 23:1", "The Lord is my shepherd, I shall not want."),
            new Scripture("Genesis 1:1-2", "In the beginning God created the heaven and the earth.And the earth was without form, and void; and darkness was upon the face of the deep. And the Spirit of God moved upon the face of the waters."),
        };

        Random random = new Random();
        
        while (scriptures.Count > 0)
        {
            int scriptureIndex = random.Next(scriptures.Count);
            Scripture scripture = scriptures[scriptureIndex];

            scripture.GetDisplayText();

            while (true)
            {
                Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit ");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    scriptures.RemoveAt(scriptureIndex); //Removing scripture if user quits
                    break;
                }

                scripture.HideRandomWords();
                scripture.GetDisplayText();

                if (scripture.IsCompletelyHidden())
                {
                    scriptures.RemoveAt(scriptureIndex); //Removing scripture if all words are hidden
                    Console.WriteLine("\nAll words hidden for this scripture.");
                    break;
                }
            }

        }

        Console.WriteLine("\nAll words hidden. Program ended.");
    }

    //.....................
}