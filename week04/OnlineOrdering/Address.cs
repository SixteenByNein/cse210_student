class Address()
{

    string _streetAddress;
    string _city;
    string _state;
    string _country;


    public void SetAddress(string streetAddress, string city, string state, string country)
    {

        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;

    }


    public bool Local()
    {

        return _country == "USA";

    }

    public string Full()
    {

        return $"{_streetAddress} {_city}, {_state}, {_country}";

    }

}