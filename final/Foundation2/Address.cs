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
        return true;
    }
    public string ReturnAddress()
    {
        return "";
    }
}