using System;

public class Shape
{
    //Add the color member variable to the Shape class.
    private string _color;

    //Add a getter and setter to the class.
    public string GetColor()
    {
        return _color;
    }


    public void SetColor(string color)
    {
        _color = color;
    }

    // Create a constructor that accepts the color and set its.
    public Shape(string color)
    {
        _color = color;
    }

    //Create a virtual method for GetArea().
    public virtual double GetArea()
    {
        return 0.0; // This is a Default implementation, can be overridden by derived classes
    }



}