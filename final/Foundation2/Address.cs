public class Address
{
    private string _street ;
    private string _state ;
    private string _country ;

    public Address()
    {

    }
    public string CountryIsUSA()
    {
        if (_country == "USA" || _country == "United States of America")
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