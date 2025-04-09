using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        
        Console.WriteLine("-------------------------------------------");
        // Test the Square class
    
        // Create a new instance of the Square class with a color and side length
        Square mySquare = new Square("Red", 5.0);
        Rectangle myRectangle = new Rectangle("Blue", 4.0, 6.0);
        Circle myCircle = new Circle("Green", 3.0);
        

        // call the GetColor() and GetArea() methods and make sure they return the values you expect.
        // Print the color and area of the square
        Console.WriteLine($"The Square Color is {mySquare.GetColor()} and the Area is {mySquare.GetArea()}.");
        // Print the color and area of the rectangle
        Console.WriteLine($"The Rectangle Color is {myRectangle.GetColor()} and the Area is {myRectangle.GetArea()}.");
        // Print the color and area of the circle
        Console.WriteLine($"The Circle Color is {myCircle.GetColor()} and the Area is {myCircle.GetArea()} ");

        Console.WriteLine("-------------------------------------------");
        // Build a List
        //In your Main method, create a list to hold shapes (Hint: The data type should be List<Shape>).
        List<Shape> shapes = new List<Shape>();
        {
            //Add the three shapes you created above to the list.
            shapes.Add(mySquare);
            shapes.Add(myRectangle);
            shapes.Add(myCircle);
        }

        //Iterate through the list of shapes. For each one, call and display the GetColor() and GetArea() methods.
        foreach (Shape myshape in shapes)
        {
            Console.WriteLine($"The Shape Color is {myshape.GetColor()} and the Area is {myshape.GetArea()}.");
        }

        // OUR INSTRUCTOR VERSION: Contain shortcut to write all the code above in one go.
        // Uncomment the code below to see how it works.

        // Notice that the list is a list of "Shape" objects. That means
        // you can put any Shape objects in there, and also, any object where
        // the class inherits from Shape
        // List<Shape> shapes = new List<Shape>();

        // Square s1 = new Square("Red", 3);
        // shapes.Add(s1);

        // Rectangle s2 = new Rectangle("Blue", 4, 5);
        // shapes.Add(s2);

        // Circle s3 = new Circle("Green", 6);
        // shapes.Add(s3);

        // foreach (Shape s in shapes)
        // {
        //     // Notice that all shapes have a GetColor method from the base class
        //     string color = s.GetColor();

        //     // Notice that all shapes have a GetArea method, but the behavior is
        //     // different for each type of shape
        //     double area = s.GetArea();

        //     Console.WriteLine($"The {color} shape has an area of {area}.");
        // }


        Console.WriteLine();
    }
    
}