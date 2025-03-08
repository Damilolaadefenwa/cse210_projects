using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        // print a message to the user
        Console.WriteLine("Enter a list of numbers, type 0 when finished:");
        // Declare and initialize a list of integers
        List<int> numbers = new List<int>();
        // Continue to add number to the list
        while (true)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                break;
            }
            numbers.Add(number);
        }
        // sum the numbers in the list
        int sum = 0;    
        foreach (int number in numbers)
        {
            sum += number;
            Console.WriteLine($"The sum is: {sum}");
        }
        // find the average of the numbers in the list
        double average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        // find the largest number in the list
        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");

    }
}