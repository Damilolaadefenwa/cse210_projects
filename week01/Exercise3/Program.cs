using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // Part 1 and 2
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        // Console.Write("What is guess number? ");
        // int userGuess = int.Parse(Console.ReadLine());

        //int userNumber = 0;
        // Part 3 using random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        
        int userGuess = -1;
        magicNumber = 42; // For testing purposes, I'll set the magic number to 42

        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine("The magic number is between 1 and 100.");
        Console.WriteLine("Try to guess the magic number!");
        
        while (userGuess != magicNumber)
        {
            Console.Write("What is your guess?: ");
            userGuess = int.Parse(Console.ReadLine());

            if (magicNumber > userGuess)
            {
                Console.WriteLine("Go Higher!");
            }
            else if (magicNumber < userGuess)
            {
                Console.WriteLine("Go Lower!");
            }
            else
            {
                Console.WriteLine("Congratulation! You guessed it!");
            }
        }                

    }
}