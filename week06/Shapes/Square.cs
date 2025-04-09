using System;

public class Square : Shape
{
    private double _side;

    // Create a constructor that accepts the color and the side, 
    // and then call the base constructor with the color.
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    //Override the GetArea() method from the base class and fill in the body of this function to return the area of the square.
    public override double GetArea()
    {
        return _side * _side; // Area of a square is side^2
    }

    // Go and Test the Square class in the Main method in Program.cs file.


}