public class Reception : Event
{
    public Reception(string title, string description, string date, string time, Address address) : base (title, description, date, time, address)
    {
        
    }
    private string _rsvpEmail ;
}