using System;

class Program
{    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        // 4. verify that you can create fractions using all three of these constructors. 
        // For example, create an instance for 1/1 (using the first constructor), 
        // for 6/1 (using the second constructor), 
        // for 6/7 (using the third constructor).

        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);
        // Console.WriteLine(f1);  
        // Console.WriteLine(f2);  
        // Console.WriteLine(f3);

      // 5. verify that you can call all of these methods and get the correct values, 
      // using setters to change the values and then getters to retrieve 
      // these new values and then display them to the console. 
      Console.WriteLine("----------------------------");
      f1.SetTop(5);
      Console.WriteLine(f1.GetTop());
      f1.SetBottom(1);
      Console.WriteLine(f1.GetBottom());

      f2.SetTop(6);
      Console.WriteLine(f2.GetTop());
      f1.SetBottom(1);
      Console.WriteLine(f2.GetBottom());

      f3.SetTop(7);
      Console.WriteLine(f3.GetTop());
      f3.SetBottom(1);
      Console.WriteLine(f3.GetBottom());


      // 6. Verify that you can call each constructor and that you can retrieve and display 
      // the different representations for a few different fractions. For example, you could try:
      Console.WriteLine("----------------------------");
      Fraction fraction1 = new Fraction(1, 1);
      Console.WriteLine("Fraction: " + fraction1.GetFractionString());
      Console.WriteLine("Decimal: " + Fraction.GetDecimalValue(1)); // Pass an appropriate integer argument
      
      Fraction fraction2 = new Fraction(5, 1);
      Console.WriteLine("Fraction: " + fraction2.GetFractionString());
      Console.WriteLine("Decimal: " + Fraction.GetDecimalValue(5));

      Fraction fraction3 = new Fraction(3, 4);
      Console.WriteLine("Fraction: " + fraction3.GetFractionString());
      Console.WriteLine("Decimal: " + Fraction.GetDecimalValue(3));
      



    }







}