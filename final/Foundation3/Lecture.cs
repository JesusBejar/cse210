public class Lecture : Event
{
    public Lecture(string title, string description, string date, string time, Address address,string eventType,string eventInfo) : base (title, description, date, time, address, eventType, eventInfo)
    {
        _speakerNameAndCapacity = eventInfo;
    }
    private string _speakerNameAndCapacity ;

    public string eventType ()
    {
        return "Lecture";
    }
    public string eventInfo()
    {
        return $"{_speakerNameAndCapacity}";
    }
}