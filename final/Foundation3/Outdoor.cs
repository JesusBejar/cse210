public class Outdoor : Event
{
    public Outdoor(string title, string description, string date, string time, Address address) : base (title, description, date, time, address)
    {
        
    }
    private string _weatherStatement ;
}