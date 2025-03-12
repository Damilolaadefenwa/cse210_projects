using System;

public class Job
{
    public string _company;  // This is a field. It is a variable member that is declared in a class.
    public string _jobTitle;
    public int _startYear;  // This is a field. It is a variable member that is declared in a class.
    public int _endYear;
    

    // This is a constructor. It is a method or activator or actualization that is called when an object is created.
    //public Job(string company, string jobTitle, int startYear, int endYear)
    //{
        //_company = company;  // this keyword is used to refer to the current instance of the class.
        //_jobTitle = jobTitle;
        //_startYear = startYear;
        //_endYear = endYear;
    //}

    // This is a method. It is a function that is defined in a class.
    public void display()
    {
        //Console.WriteLine($"{_jobTitle} {_company}");
        Console.WriteLine($"{_jobTitle} {_company} {_startYear} - {_endYear}");
    }
        
    

}
