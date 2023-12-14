using System.Dynamic;

public class Address
{
    private string street;
    private int number;
    private string city;
    private string state;
    private string country;

    public Address(string _street, int _number, string _city, string _state, string _country)
    {
        street = _street;
        number = _number;
        city = _city;
        state = _state;
        country = _country;

    } 

    public string GetAddress()
    {
        return $"{street} {number}, {city}. {state}. {country}";
    }
}