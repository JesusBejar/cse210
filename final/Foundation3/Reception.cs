public class Reception : Event
{
    public Reception(string title, string description, string date, string time, Address address, string eventType, string rsvpEmail) : base (title, description, date, time, address, eventType)
    {
        _rsvpEmail = rsvpEmail;
    }
    private string _rsvpEmail ;

    public string eventType()
    {
        return "Reception";
    }
}