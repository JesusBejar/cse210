public class Address
{
    private string _street ;
    private string _state ;
    private string _country ;

    public Address()
    {

    }
    public bool CountryIsUSA()
    {
        if (_country == "USA" || _country == "United States of America")
        {
            return true;
        }
        else 
        {
            return false;
        }

    }
    public string ReturnAddress()
    {
        return $"{_street} {_state} {_country}";
    }
}