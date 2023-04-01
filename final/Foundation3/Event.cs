public class Event
{
    public Event(string title, string description, string date, string time, Address address, string eventType, string eventInfo)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;
        _eventInfo = eventInfo;
    }

    private string _title ;
    private string _description ;
    private string _date ;
    private string _time ;
    private Address _address ;
    private string _eventType ; 
    private string _eventInfo ;

    // Standard details - Lists the title, description, date, time, and address.
    // Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
    // Short description - Lists the type of event, title, and the date.
    public void DisplayStandardDetails()
    {
        Console.WriteLine("\nStandard Details:");
        Console.WriteLine($"{_title} {_description} {_date} {_time} {_address.ReturnAddress()}");
    }
    public void DisplayFullDetails(string eventType, string eventInfo)
    {
        Console.WriteLine("\nFull Details:");
        Console.WriteLine($"Event type : {_eventType} \n{_title} {_description} {_date} {_time} {_address.ReturnAddress()} \nAdditional info : {_eventInfo}");
    }
    public void DisplayFewDetails(string eventType)
    {
        Console.WriteLine("\nFew Details:");
        Console.WriteLine($"Event type : {_eventType} \n{_title} {_date}");
    }
}