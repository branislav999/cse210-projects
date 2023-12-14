public class Customer
{
    private string name;
    private Address address;
    
    public bool IsInUsa()
    {
        if (address.GetCountry() == "USA")
        {
            return true;
        }

        else
        {
            return false;
        }
    }
    
    public string GetLabel()
    {
        return $"{name}{address.GetAddress()}";
    }


    public Customer()
    {

    }

    public Customer(string _name, Address _address)
    {
        name = _name;
        address = _address;
    }
}

