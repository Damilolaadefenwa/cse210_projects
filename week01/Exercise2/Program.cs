using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.WriteLine("Please enter your score number to get your grade: ");
        string userInput = Console.ReadLine();
        int gradenumber = int.Parse(userInput);

        string letter = ""; 

        if (gradenumber >= 90)
        {
            letter = "A";
        }
        else if (gradenumber >= 80)
        {
            letter = "B";
        }
        else if (gradenumber >= 70)
        {
            letter = "C";
        }
        else if (gradenumber >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        Console.WriteLine($"Your grade is {letter}");

        if (gradenumber >= 70)
        {
            Console.WriteLine("Congratulation! You passed the course.");
        }
        else
        {
            Console.WriteLine("Oops! Best of luck next time.");
        }


    }
}