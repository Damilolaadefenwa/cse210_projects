using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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

        bool running = true;
        while (running)
        {
            Console.Clear();
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
                    ListGoalNames();
                    break;
                case "3":
                    SaveGoalsToFile("");
                    break;
                case "4":
                    LoadGoalsFromFile("");
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    running = false; // Set running to false to exit the loop
                    Console.WriteLine("Exiting the program..."); // Exit the loop and end the program
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    
    // DisplayPlayerInfo - This method displays the players current score.
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        // Console.WriteLine($"Current Score is: {_score}");
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
        Console.WriteLine($"The event recorded for {selectedGoal.GetNames()}! Your score is now {_score}.");
    }

    //SaveGoals - Saves the list of goals to a file.
    public void SaveGoalsToFile(string filePath)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"Score: {_score}"); // Save the current score to the file

                foreach (var goal in _goals)
                {
                    writer.WriteLine(goal.GetstringRepresentation()); // Save each goal's string representation to the file
                }
            }
            Console.WriteLine("Goals saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }

    }

    // LoadGoals - Loads the list of goals from a file.
    public void LoadGoalsFromFile(string filePath)
    {
        
        if (File.Exists(filePath))
        
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath, System.Text.Encoding.UTF8);
                if (lines.Length > 0 && int.TryParse(lines[0], out int savedScore))
                {
                    _score = savedScore;
                }
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(':');
                    string goalType = parts[0];
                    string name = parts[1];
                    int points = int.Parse(parts[2]);

                    switch (goalType)
                    {
                        case "SimpleGoal":
                            bool isComplete = int.Parse(parts[3]) == 1;
                            _goals.Add(new SimpleGoal(name, " ", points.ToString()));
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(name,"", points.ToString()));
                            break;
                        case "ChecklistGoal":
                            int targetCount = int.Parse(parts[3]);
                            int completedCount = int.Parse(parts[4]);
                            int bonusPoints = int.Parse(parts[5]);
                            _goals.Add(new ChecklistGoal(name, "", points.ToString(), targetCount, bonusPoints));
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
    
        // try
        // {
        //     using (StreamReader reader = new StreamReader(filePath))
        //     {
        //         string scoreLine = reader.ReadLine();
        //         if (scoreLine != null && scoreLine.StartsWith("Score: "))
        //         {
        //             _score = int.Parse(scoreLine.Substring(7)); // Extract the score from the line
        //         }

        //         _goals.Clear(); // Clear the existing goals before loading new ones

        //         string line;
        //         while ((line = reader.ReadLine()) != null)
        //         {
        //             // Parse the goal type and create the appropriate goal object
        //             if (line.StartsWith("SimpleGoal: "))
        //             {
        //                 _goals.Add(new SimpleGoal(line.Substring(12))); // Create a SimpleGoal object
        //             }
        //             else if (line.StartsWith("EternalGoal: "))
        //             {
        //                 _goals.Add(new EternalGoal(line.Substring(13))); // Create an EternalGoal object
        //             }
        //             else if (line.StartsWith("ChecklistGoal: "))
        //             {
        //                 _goals.Add(new ChecklistGoal(line.Substring(15))); // Create a ChecklistGoal object
        //             }
        //         }
        //     }
        //     Console.WriteLine("Goals loaded successfully.");
        // }
        // catch (Exception ex)
        // {
        //     Console.WriteLine($"Error loading goals: {ex.Message}");
        // }

    }


    
}