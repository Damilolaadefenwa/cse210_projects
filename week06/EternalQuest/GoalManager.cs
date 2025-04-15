using System;
using System.Collections.Generic;
using System.IO;

// I exceeded requirement by adding Visual Enhancements to the public void ListGoalsDetails() method.
// in order to make a colour coded out put for the goals based on their completion status.
public  class GoalManager
{
    private List<Goal> _goals; // List to store the goals created by the user
    // private List<Goal> _goals = new List<Goal>; // List to store the goals created by the user
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
        bool isRunning = true; // Flag to control the 
        while (isRunning)
        {
            // Console.Clear();
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
                    isRunning = false; // Set the flag to false to exit the loop
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
       
        // Console.WriteLine("Debugging the ListGoalsDetails():This function is working................................");
        // Console.WriteLine("List of Goals are: ");
        // Console.WriteLine($"Debug: _goals count = {_goals.Count}");
        
        try
        {
            Console.WriteLine("List of Goals are:: ");
            if (_goals.Count == 0) // Check if there are no goals
            {
                Console.WriteLine("No goals created yet.");
                return; // Exit the method if no goals exist
            }
            else
            {
                for (int i = 0; i < _goals.Count; i++) // Loop through the goals list
                {
                    Console.Write($"{i + 1}. "); 
                    if (_goals[i].IsComplete()) // Check if the goal is complete
                    {
                        Console.ForegroundColor = ConsoleColor.Green; // Green for completed goals
                    }
                    else if (_goals[i] is EternalGoal) // Check if the goal is an EternalGoal
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow; // Yellow for eternal goals
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue; // Default color for other goals
                    }
                    
                    Console.WriteLine(_goals[i].GetDetailsString()); // Display or Print each goal's details
                    
                } 
                Console.WriteLine("End of Goals List.");
                Console.ResetColor(); // Reset the console color to default
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error listing goals: {ex.Message}");
        }
        

        // try
        // {
        //     Console.WriteLine("List of Goals are:: ");
        //     if (_goals.Count == 0) // Check if there are no goals
        //     {
        //         Console.WriteLine("No goals created yet.");
        //         return; // Exit the method if no goals exist
        //     }
        //     else
        //     {
        //         for (int i = 0; i < _goals.Count; i++) // Loop through the goals list
        //         {
        //             Console.Write($"{i + 1}. "); 
        //             // _goals[i].GetDetailsString(); // lines not working due to syntax error
        //             Console.WriteLine(_goals[i].GetDetailsString()); // Display or Print each goal's details
        //         } 
        //         Console.WriteLine("End of Goals List.");
        //     }
        // }
        // catch (Exception ex)
        // {
        //     Console.WriteLine($"Error listing goals: {ex.Message}");
        // }
        
    }

    // ListGoalNames - This method Lists the names of each of the goals.
    public void ListGoalNames()
    {
        // Console.WriteLine("Debugging ListGoalNames():This function is working................................");
        
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

        // Console.WriteLine("Debugging RecordEvent():This function is working................................");
        // // Console.WriteLine("Record an Event for a Goal:");
        // Console.WriteLine("---------------------------------");

        Console.WriteLine("The goals are as follow:");
        ListGoalNames(); // Display the list of goal names / details to the user

        if (_goals.Count == 0) return;

        Console.Write("Which goal did you accomplish? (Enter the number): ");
        if (int.TryParse(Console.ReadLine(), out int goalNumber) && goalNumber > 0 && goalNumber <= _goals.Count)
        {
            Goal goal = _goals[goalNumber - 1];
            int pointsEarned = goal.GetPoints(); // Assume RecordEvent() returns the points earned for this event
            _score += pointsEarned;    // Update the total score
            Console.WriteLine($"Congratulations! You earned {pointsEarned} points for '{goal.GetNames()}'. Your new score is {_score}.");
            // // int previousScore = _score;
            // // goal.RecordEvent();
            // _score += goal.GetPoints();
            // Console.WriteLine($"Congratulations! You earned {goal.GetPoints() - (previousScore == _score ? 0 : _goals[goalNumber - 1].GetPoints())} points for ' {goal.GetNames()}'. Your new score is {_score}.");
        }
        else
        {
            Console.WriteLine("Invalid goal Number. ");
        }
    }

    // DisplayPlayerInfo - This method displays the players current score.
    public void DisplayPlayerInfo()
    {
        // Console.WriteLine("Debbugging: DisplayPlayerInfo(). This function is working................................");

        Console.WriteLine($"You have {_score} points.");   // Display the current score
        // Console.WriteLine($"Your current score is: {score}");
    }

    // SaveGoals - Saves the list of goals to a file.
    public void SaveGoalsToFile(string filePath)
    {
        // Console.WriteLine("Debugging: SaveGoalsToFile() This function is working................................");
        
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
        // Console.WriteLine("Debugging LoadGoalsFromFil().This function is working................................");

        if (File.Exists(savedfile))
        
        {
            try
            {
                string[] lines = File.ReadAllLines(savedfile); //
                if (lines.Length > 0 && int.TryParse(lines[0], out int savedScore))
                {
                    _score = savedScore;
                }
                
                // _goals.Clear(); // Clear existing goals before loading new ones
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                   
                    // Validate the line format
                    if (parts.Length < 4) // Ensure there are enough parts
                    {
                        Console.WriteLine($"Skipping invalid line {i}: {lines[i]}");
                        continue; // Skip this line and move to the next
                    }
                
                    string goalType = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    if (!int.TryParse(parts[3], out int points))
                    {
                        Console.WriteLine($"line: {i}: {lines[i]}");
                        continue; // Skip this line if points are invalid
                    }
                   
                    switch (goalType)
                {
                    case "SimpleGoal":
                        _goals.Add(new SimpleGoal(name, description, points));
                        break;
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(name, description, points));
                        break;
                    case "ChecklistGoal":
                        if (parts.Length < 5 || !int.TryParse(parts[4], out int target) || !int.TryParse(parts[5], out int bonus))
                        {
                            Console.WriteLine($"line: {i}: {lines[i]}");
                            continue; // Skip this line if target or bonus is invalid
                        }
                        _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                        break;
                    default:
                        Console.WriteLine($"unknown-goal line: {i}: {lines[i]}");
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