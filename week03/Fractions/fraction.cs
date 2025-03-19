using System;

// 3. Create the Fraction class.
// It has two fields / member variables: _top and _bottom, which are the numerator and denominator of the fraction.
class Fraction
{
    private int _top;
    private int _bottom;

    // 4. Create a constructor which is a special method that is called when an object is created.
    // It is used to initialize the object.

    // a. Create the Constructor that has no parameters that initializes the number to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // b. Create the Constructor Constructor that has one parameter for the top and that initializes the denominator to 1. So that if you pass in the number 5, the fraction would be initialized to 5/1.
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // c. Create the Constructor that has two parameters, one for the top and one for the bottom.
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }


    // 5. Create getters and setters for both the top and the bottom values.

    // Getter for numerator
    public int GetTop()
    {
        return _top;
    }
    // Setter for numerator
    public void SetTop(int top)
    {
        _top = top;
    }
    // Getter for Denominator
    public int GetBottom()
    {
        return _bottom;
    }
    // Setter for Denominator
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }


    //6. Create methods to return the representations
    // A. Create a method called GetFractionString that returns the fraction in the form 3/4.
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    // B. Create a method called GetDecimalValue that returns a double that is the result of dividing 
    // the top number by the bottom number, such as 0.75.
    public static double GetDecimalValue(int value)
    {
        // Implementation goes here
        return 0.0; // Placeholder return value
    }


}


