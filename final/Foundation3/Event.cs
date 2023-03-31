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

    // Standard details - Lists the title, description, date, time, and address.
    // Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
    // Short description - Lists the type of event, title, and the date.
    public string DisplayStandardDetails()
    {
        return $"{_title} {_description} {_date} {_time} {_address}";
    }
    public string DisplayFullDetails()
    {
        return $"{_title} {_description} {_date} {_time} {_address}";
    }
    public string DisplayFewDetails()
    {
        return $"{_title} {_description} {_date}";
    }
}