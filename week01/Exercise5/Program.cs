using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        //For this assignment, write a C# program that has several simple functions.
        WelcomeMessage();
        string userName = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(userName, squaredNumber);

        //Displays the message, "Welcome to the Program!" to the user.
          static void WelcomeMessage()
          {
              Console.WriteLine("Welcome to the Program!");
          }

        // Asks for and returns the user's name (as a string)
         static string PromptUserName()
         {
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
             
            return userName;
         }

        // Asks for and returns the user's favorite number (as an integer)
         static int PromptUserNumber()
         {
            Console.WriteLine("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            
            return number;
         }

        // Accepts an integer as a parameter and returns that number squared (as an integer)
            static int SquareNumber(int number)
            {
                int square = number * number;
                return square;
            }

        //Accepts the user's name and the squared number and displays them.
            static void DisplayResult(string userName, int squaredNumber)
            {
                Console.WriteLine($"{userName}! the square of your number is {squaredNumber}.");
            }
    }
    
}