public class Outdoor : Event
{
    public Outdoor(string title, string description, string date, string time, Address address,string eventType,string eventInfo) : base (title, description, date, time, address, eventType, eventInfo)
    {
        _weatherStatement = eventInfo;
    }
    private string _weatherStatement ;

    public string eventType ()
    {
        return "Outdoor";
    }
    public string eventInfo()
    {
        return $"{_weatherStatement}";
    }
}