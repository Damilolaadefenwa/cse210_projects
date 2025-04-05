using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine("----------------------------------");

        BreathingActivity breathing = new BreathingActivity(0);
        ReflectingActivity reflecting = new ReflectingActivity(new List<string>(), new List<string>());

        Console.WriteLine("Welcome to the Mindfulness Program!");
        while (true)
        {
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    breathing.Run();
                    break;
                case "2":
                    reflecting.Run();
                    break;
                // case "3":
                //     ListingActivity listing = new ListingActivity("", "", 0);
                //     listing.GetListFromUser();
                //     break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }


        }



    }
}