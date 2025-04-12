using System;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    
    // Constructor to initialize the goal manager with an empty list of goals and a score of 0 
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        //LoadGoalsFromFile(); // Load goals from a file when the manager is created
    }

    // This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
   // Start() method is the main entry point for the GoalManager class. It displays a menu and handles user input.
    // public void Start()
    // {
    //     bool running = true;
    //     while (running)
    //     {
    //         Console.Clear();
    //         Console.WriteLine("Welcome to the Eternal Quest! What would you like to do?");
    //         Console.WriteLine("1. Create a new goal");
    //         Console.WriteLine("2. List all goals");
    //         Console.WriteLine("3. Record an event for a goal");
    //         Console.WriteLine("4. Save goals to file");
    //         Console.WriteLine("5. Load goals from file");
    //         Console.WriteLine("6. Show score");
    //         Console.WriteLine("7. Quit");

    //         string choice = Console.ReadLine();

    //         switch (choice)
    //         {
    //             case "1":
    //                 CreateGoal();
    //                 break;
    //             case "2":
    //                 ListGoals();
    //                 break;
    //             case "3":
    //                 RecordEvent();
    //                 break;
    //             case "4":
    //                 SaveGoalsToFile();
    //                 break;
    //             case "5":
    //                 LoadGoalsFromFile();
    //                 break;
    //             case "6":
    //                 ShowScore();
    //                 break;
    //             case "7":
    //                 running = false;
    //                 break;
    //             default:
    //                 Console.WriteLine("Invalid choice, please try again.");
    //                 break;
    //         }
    //     }
    // }

    // DisplayPlayerInfo - This method displays the players current score.
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score is: {_score}");
    }
    // ListGoalNames - This method Lists the names of each of the goals.
    public void ListGoalNames()
    {
        Console.WriteLine("Goals Names:");
        if (_goals.Count == 0) // Check if there are no goals
        {
            Console.WriteLine("No goals created yet.");
            return; // Exit the method if no goals exist
        }
        for (int i = 0; i < _goals.Count; i++) // Loop through the goals list
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetNames()}"); // Display or Print each goal's name
        }

    }
    // ListGoalDetails - This method Lists the details of each goal (including the checkbox of whether it is complete).
    public void ListGoalDetails()
    {
        Console.WriteLine("Goals Detail:");
        if (_goals.Count == 0) // Check if there are no goals
        {
            Console.WriteLine("No goals created yet.");
            return; // Exit the method if no goals exist
        }
        for (int i = 0; i < _goals.Count; i++) // Loop through the goals list
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}"); // Display or Print each goal's details
        }
    }
    // CreateGoal - This method asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    public void CreateGoal()
    {
        Console.WriteLine("Enter the type of goal (Simple, Checklist, Eternal): ");
        string goalType = Console.ReadLine().ToLower(); // Read the goal type from user input

        Console.WriteLine("Enter the short name of the goal: ");
        string shortName = Console.ReadLine(); // Read the short name from user input

        Console.WriteLine("Enter the description of the goal: ");
        string description = Console.ReadLine(); // Read the description from user input

        Console.WriteLine("Enter the points for the goal: ");
        string points = Console.ReadLine(); // Read the points from user input

        Goal newGoal = null; // Initialize a new goal variable

        switch (goalType) // Determine which type of goal to create based on user input
        {
            case "simple":
                newGoal = new SimpleGoal(shortName, description, points); // Create a SimpleGoal
                break;
            case "checklist":
                Console.WriteLine("Enter the target number of completions: ");
                int target = int.Parse(Console.ReadLine()); // Read target number from user input
                Console.WriteLine("Enter the bonus points for completing the checklist: ");
                int bonus = int.Parse(Console.ReadLine()); // Read bonus points from user input
                newGoal = new ChecklistGoal(shortName, description, points, target, bonus); // Create a ChecklistGoal
                break;
            case "eternal":
                newGoal = new EternalGoal(shortName, description, points); // Create an EternalGoal
                break;
            default:
                Console.WriteLine("Invalid goal type. Please try again."); // Handle invalid input
                return; // Exit the method if invalid type is entered
        }

        _goals.Add(newGoal); // Add the newly created goal to the list of goals
        Console.WriteLine($"New {goalType} goal created successfully!"); // Confirmation message
    }





















    
}