using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    // public string GetWritingInformation()
    // {
    //     return $"" + _title + " by " + _studentName;
    // }

    // Adding instructor approach to the WritingAssignment class.
    // The method can be written like this as well:

    public string GetWritingInformation()
    {
        // Notice that we are calling the getter here because _studentName is private in the base class
        // and we cannot access it directly.

        string studentName = GetStudentName();

        return $"{_title} by {studentName}";

    }

}