using System;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>(); // This is a field. It is a variable member that is declared in a class.



    //this is a method. It is a function that is defined in a class.public void display()
    public void display()
    {
        _name = "John Doe";


        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Notice the use of the custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            // This calls the Display method on each job
            job.display();
        }

    }

}

