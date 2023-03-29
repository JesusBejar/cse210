public class Reception : Event
{
    public Reception(string rsvpEmail)
    {
        _rsvpEmail = rsvpEmail;
    }
    private string _rsvpEmail ;
}