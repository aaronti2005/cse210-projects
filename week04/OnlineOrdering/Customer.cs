using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetName()
    {
        string name = $"Name: {_name}";
        return name;
    }

    public string GetAddress()
    {
        string address = _address.GetFullAddress();
        return address;
    }

}