using System;

public class Circle : Shape
{
    private double _radius;

    // Create a constructor that accepts the color and the radius, 
    // and then call the base constructor with the color.
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    //Override the GetArea() method from the base class and fill in the body of this function to return the area of the circle.
    public override double GetArea()
    {
        // return Math.PI * _radius * _radius; //The area of a circle is π * radius^2
        // return _radius * _radius * Math.PI; // The instructor version.
        return Math.Round(Math.PI *_radius * _radius, 2); // The area of a circle is π * radius^2, rounded to 2 decimal places
    }






}