using System;

public class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    // This is a Constructor to initialize the member variable
    public Product(string Name, int ProductId, double price, int quantity)
    {
        _name = Name;
        _productId = ProductId;
        _price = price;
        _quantity = quantity;
    }

    // This method calculates the total cost of the product.
    public double CalculateTotalCost()
    {
        return _price * _quantity;
    }

    //This method return a formatted string for the product details.
    public string packingLabel()
    {
        return $"{_name}, (ID: {_productId})\n";
    }
}