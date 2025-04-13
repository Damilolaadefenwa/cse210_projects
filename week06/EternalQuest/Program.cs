using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        Console.WriteLine("-----------------------------------------------");
        GoalManager mymanager = new GoalManager();
        mymanager.Start();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        Console.WriteLine("Goodbye! Thank you for playing the EternalQuest Project.");
        
    }
    
}