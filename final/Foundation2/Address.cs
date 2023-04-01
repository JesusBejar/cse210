public class Address
{
    private string _street ;
    private string _state ;
    private string _country ;

    public Address(string street, string state, string country)
    {
        _street = street;
        _state = state;
        _country = country;
    }
    public string CountryIsUSA()
    {
        if (_country == "US" || _country == "USA" || _country == "United States" || _country == "United States of America" )
        {
            return $"USA"; 
        }
        else 
        {
            return $"{_country}"; 
        }
    }
    public string ReturnAddress()
    {
        return $"{_street} {_state} {_country}";
    }
    
}