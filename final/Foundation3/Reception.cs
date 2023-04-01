public class Reception : Event
{
    public Reception(string title, string description, string date, string time, Address address, string eventType, string eventInfo) : base (title, description, date, time, address, eventType, eventInfo)
    {
        _rsvpEmail = eventInfo;
    }
    private string _rsvpEmail ;

    public string eventType()
    {
        return "Reception";
    }
    public string eventInfo()
    {
        return $"{_rsvpEmail}";
    }
}