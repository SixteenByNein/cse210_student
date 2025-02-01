class Customer()
{

    string _name;
    Address _address;

    public void SetCustomer(string name, Address address)
    {

        _name = name;
        _address = address;

    }

    public bool Local()
    {

        return _address.Local();

    }

    public string GetName()
    {

        return _name;

    }

    public string GetAddress()
    {

        return _address.Full();

    }

}