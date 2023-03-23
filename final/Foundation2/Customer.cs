public class Customer
{
    private string _name ;
    private Address _address ;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool CountryIsUSA(string country)
    {
        if (country == "USA")
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
    public string ReturnCustomer()
    {
        return $"{_name} {_address.ReturnAddress()}";
    }
}