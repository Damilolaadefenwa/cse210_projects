using System;

public class Comment
{
    public string _personCommenting; // is a variable member that handle the name of the person who made the comment
    public string _commentText; // is a variable member that handle the text of the comment.


    //A constructor that initializes the member variables of this class
    public Comment(string personCommenting, string commentText)
    {
        _personCommenting = personCommenting;
        _commentText = commentText;
    }

}