using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        Console.WriteLine("-----------------------------------------------");
        GoalManager mymanager = new GoalManager();
        // mymanager.Start();
        
        //TEST SOME FUNCTIONS
        // test 1
        // mymanager.CreateGoal();
        // // test 2
        // Console.WriteLine("----------------------------------------");
        // mymanager.ListGoalNames();
        // //  // test 3
        // Console.WriteLine("----------------------------------------");
        // mymanager.ListGoalsDetails();
        // // // test 4
        // mymanager.SaveGoalsToFile("Myfile.txt");
        // test 5
        // Console.WriteLine("----------------------------------------");
        // mymanager.LoadGoalsFromFile("Myfile.txt");
        // test 6
        // Console.WriteLine("----------------------------------------");
        // mymanager.RecordEvent();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        Console.WriteLine("Goodbye! Thank you for playing the EternalQuest Project.");
        
    }
    
}