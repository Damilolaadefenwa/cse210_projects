using System;
using System.Collections.Generic;
using System.IO;

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
    public void Start()
    {   
    
        DisplayPlayerInfo(); // Display the player's current score at the start

        while (true)
        {
            Console.Clear();
            DisplayPlayerInfo(); // Display the player's current score
            Console.WriteLine("Menu Options! What would you like to do?");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save goals to file");
            Console.WriteLine("4. Load goals from file");
            Console.WriteLine("5. Record an event for a goal");
            Console.WriteLine("6. Quit");

            Console.Write("Select a Choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalsDetails();
                    break;
                case "3":
                    Console.Write("Enter the file path to save goals: ");
                    string filePath = Console.ReadLine();
                    SaveGoalsToFile(filePath);
                    break;
                case "4":
                    Console.Write("Enter the file path to load goals: ");
                    string savedfile = Console.ReadLine();
                    LoadGoalsFromFile(savedfile);
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Thank you for playing Eternal Quest!"); // Exit the loop and end the program
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
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
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                if (!int.TryParse(Console.ReadLine(), out int target))
                {
                    Console.WriteLine("Invalid target count input.");
                    return;
                }
                Console.Write("What is the bonus points for accomplishing it that many times? ");
                if (!int.TryParse(Console.ReadLine(), out int bonus))
                {
                    Console.WriteLine("Invalid bonus points input.");
                    return;
                }
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
        Console.WriteLine("Goal created successfully.");

    }
    
    // ListGoalDetails - This method Lists the details of each goal (including the checkbox of whether it is complete).
    public void ListGoalsDetails()
    {
        Console.WriteLine("Your Goals:");
        _goals.Add(new SimpleGoal("Test", "Test", 0)); // Add a test goal for demonstration purposes
        // _goals.Add(CreateGoal()); // Add a new goal for demonstration purposes
        if (_goals.Count == 0) // Check if there are no goals
        {
            Console.WriteLine("No goals created yet.");
            return; // Exit the method if no goals exist
        }
        for (int i = 0; i < _goals.Count; i++) // Loop through the goals list
        {
            Console.Write($"{i + 1}. "); 
            _goals[i].GetDetailsString(); // Call the GetDetailsString method to get the goal's details
        }
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

    //RecordEvent - This method asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    public void RecordEvent()
    {
        ListGoalNames(); // Display the list of goal names / details to the user
        if (_goals.Count == 0) return;

        Console.Write("Which goal did you accomplish? (Enter the number): ");
        if (int.TryParse(Console.ReadLine(), out int goalNumber) && goalNumber > 0 && goalNumber <= _goals.Count)
        {
            Goal goal = _goals[goalNumber - 1];
            int previousScore = _score;
            goal.RecordEvent();
            _score += goal.GetPoints();
            Console.WriteLine($"Congratulations! You earned {goal.GetPoints() - (previousScore == _score ? 0 : _goals[goalNumber - 1].GetPoints())} points for ' {goal.GetNames()}'. Your new score is {_score}.");
        }
        else
        {
            Console.WriteLine("Invalid goal Number. ");
        }
    }

    // DisplayPlayerInfo - This method displays the players current score.
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        // Console.WriteLine($"Your current score is: {score}");
    }

    //SaveGoals - Saves the list of goals to a file.
    public void SaveGoalsToFile(string filePath)
    {
        using (StreamWriter outputFile = new StreamWriter(filePath))
        {
            outputFile.WriteLine(_score); // Save the current score to the file

            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetstringRepresentation()); // Save each goal's string representation to the file
            }
        }
        try
        {
            Console.WriteLine("Goals and Score saved successfully.");   
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }

    }

    // LoadGoals - Loads the list of goals from a file.
    public void LoadGoalsFromFile(string savedfile)
    {
        
        if (File.Exists(savedfile))
        
        {
            try
            {
                string[] lines = File.ReadAllLines(savedfile); //
                if (lines.Length > 0 && int.TryParse(lines[0], out int savedScore))
                {
                    _score = savedScore;
                }
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(':');
                    string goalType = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    switch (goalType)
                    {
                        case "SimpleGoal":
                            bool isComplete = int.Parse(parts[3]) == 1;
                            _goals.Add(new SimpleGoal(name, description, points));
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(name, description, points));
                            break;
                        case "ChecklistGoal":
                            int target = int.Parse(parts[4]);
                            int amountcompleted = int.Parse(parts[5]);
                            int bonus = int.Parse(parts[6]);
                            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                            break;
                    }
                }
                Console.WriteLine("Goals and score loaded successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading goals: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }


    
}