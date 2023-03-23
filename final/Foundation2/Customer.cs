public class Customer
{
    private string _name ;
    private bool _address ;
    Address A = new Address();

    public Customer()
    {

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
        return $"{_name} {_address}";
    }
}