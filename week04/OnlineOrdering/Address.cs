using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    // A Constructor to initialise the member variable
    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    // This Method returns true if the country is "USA" (case-insensitive).
    public bool livesInUSA()
    {
        return _country.ToUpper() == "USA";
    }
    
    // This Method returns a formatted string with all address fields.
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}, {_country}.";
    }

}