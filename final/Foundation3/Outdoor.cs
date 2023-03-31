public class Outdoor : Event
{
    public Outdoor(string title, string description, string date, string time, Address address,string eventType, string weatherStatement) : base (title, description, date, time, address, eventType)
    {
        _weatherStatement = weatherStatement;
    }
    private string _weatherStatement ;

    public string eventType ()
    {
        return "Outdoor";
    }
}