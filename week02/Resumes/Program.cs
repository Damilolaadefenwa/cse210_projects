using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        // This is to test the Job class.
        Job job1 = new Job(); // This is an object. It is an instance of a class.
        job1._company = "Microsoft"; // This is a field. It is a variable member that is declared in a class.
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019; 
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //job1.display();
        //job2.display();
    

        // This is to test the Resumes class.
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.display();
    }

   

}