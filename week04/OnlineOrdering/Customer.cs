using System;

public class Customer
{
    private string _names;
    private Address _address;

    // A Constructor to initialise the member variable
    public Customer(string names, Address address)
    {
        _names = names;
        _address = address;
    }

    //This method delegates or call to the Address object's LivesInUSA () method to check if the customer lives in the country.
    public bool IsInUSA()
    {
        return _address.livesInUSA();
    }    

    //This method return a formatted string for the customer shipping details.
    public string shippingLabel()
    {
        return $" {_names}\n{_address.GetFullAddress()}";
    }

}