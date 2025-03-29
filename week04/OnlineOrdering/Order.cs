using System;
using System.Reflection.Emit;

public class Order
{
  private Customer _customer; //This is a variable member
  private List<Product> _products; //This is a variable member 

    // This is a constructor to initialize the member variable.
    public Order (Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    // This method calculates the total order price, including shipping.
    public double CalculateTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in _products)
        {
            totalPrice += product.CalculateTotalCost();
        }
        double shippingCost = _customer.IsInUSA() ? 5 : 35;
        return totalPrice + shippingCost;
    }

    // This method returns a string with product names and IDs.
    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"{product.packingLabel()}";
        }
        return label;
    }
 
    // This method returns a string with customer name and address.
        public string GetShippingLabel()
        {
            return $"{_customer.shippingLabel()}";
        }

}