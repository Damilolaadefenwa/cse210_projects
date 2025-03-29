using System;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;

    //Constructor to initializes the member variables of this class
    public Video (string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    // A method to returns the number of comments for the video.
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

}