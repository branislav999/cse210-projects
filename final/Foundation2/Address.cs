public class Address
{
    private string street;
    private string city;
    private string state;
    private string country;


    public Address()
    {}
    public Address(string _street, string _city, string _state, string _country)
    {
        street = _street;
        city = _city;
        state = _state;
        country = _country;
    }

    public string GetCountry()
    {
        return country;
    }
    public string GetAddress()
    {
        return $"\n{street}, {city}, {state}\n{country} ";
    }

}