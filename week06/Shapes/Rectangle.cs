using System;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    // Create a constructor that accepts the color and the length and width, 
    // and then call the base constructor with the color.
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
         _width = width;
    }

    //Override the GetArea() method from the base class and fill in the body of this function to return the area of the square.
    public override double GetArea()
    {
        return _length * _width; // The Area of a rectangle is length * width
    }



}