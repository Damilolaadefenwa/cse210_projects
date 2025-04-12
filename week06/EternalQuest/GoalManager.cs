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
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("What type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        if (!int.TryParse(Console.ReadLine(), out int points))
        {
            Console.WriteLine("Invalid points input.");
            return;
        }

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points.ToString()));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points.ToString()));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                if (!int.TryParse(Console.ReadLine(), out int targetCount))
                {
                    Console.WriteLine("Invalid target count input.");
                    return;
                }
                Console.Write("What is the bonus points for accomplishing it that many times? ");
                if (!int.TryParse(Console.ReadLine(), out int bonusPoints))
                {
                    Console.WriteLine("Invalid bonus points input.");
                    return;
                }
                _goals.Add(new ChecklistGoal(name, "", points.ToString(),  targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
        Console.WriteLine("Goal created successfully.");

    }
    
    //RecordEvent - This method asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    public void RecordEvent()
    {
        ListGoalNames(); // Display the list of goal names to the user
        Console.Write("Which goal did you accomplish? (Enter the number): ");
        if (!int.TryParse(Console.ReadLine(), out int goalIndex) || goalIndex < 1 || goalIndex > _goals.Count)
        {
            Console.WriteLine("Invalid goal selection.");
            return;
        }

        Goal selectedGoal = _goals[goalIndex - 1]; // Get the selected goal from the list
        selectedGoal.RecordEvent(); // Call the RecordEvent method on the selected goal
        _score += int.Parse(selectedGoal.GetPoints()); // Add points to the score based on the goal's points
        Console.WriteLine($"Event recorded for {selectedGoal.GetNames()}! Your score is now {_score}.");
    }



    





















    
}