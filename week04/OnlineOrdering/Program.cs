using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine("---------------------------------------------------");
        //write a program that creates at least two orders with a 2-3 products each. 
        //Call the methods to get the packing label, the shipping label, and the total
        //price of the order, and display the results of these methods.

        // Creating addresses
        Address myAddress1 = new Address("123 Flord St", "Downtown", "Califonia", "USA");
        Address myAddress2 = new Address("456 Cantabury St", "Westham", "London", "Uk");

        // Creating customers
        Customer mycustomer1 = new Customer("Jasmine Doe", myAddress1);
        Customer mycustomer2 = new Customer("Jane-Oliver Smith", myAddress2);

        // Creating products
        Product myproduct1 = new Product("Laptop", 1001, 1200, 2);
        Product myproduct2 = new Product("Mouse", 1002, 25, 4);
        Product myproduct3 = new Product("Keyboard", 1003, 50, 2);
        Product myproduct4 = new Product("Headphones", 1004, 80, 5);

        // Creating orders
        Order myorder1 = new Order(mycustomer1, new List<Product> { myproduct1, myproduct2 });
        Order myorder2 = new Order(mycustomer2, new List<Product> { myproduct3, myproduct4, myproduct1});

        // Display order details
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:\n" + myorder1.GetPackingLabel());
        Console.WriteLine("\nShipping Label:\n" + myorder1.GetShippingLabel());
        Console.WriteLine("\nTotal Price: $" + myorder1.CalculateTotalPrice());

        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:\n" + myorder2.GetPackingLabel());
        Console.WriteLine("\nShipping Label:\n" + myorder2.GetShippingLabel());
        Console.WriteLine("\nTotal Price: $" + myorder2.CalculateTotalPrice());

        Console.WriteLine();

    }
}