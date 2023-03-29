public class Event
{
    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    private string _title ;
    private string _description ;
    private string _date ;
    private string _time ;
    private Address _address ;


    public string DisplayStandardDetails()
    {
        return "";
    }
    public string DisplayFullDetails()
    {
        return "";
    }
    public string DisplayFewDetails()
    {
        return "";
    }
}