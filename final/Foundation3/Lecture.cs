public class Lecture : Event
{
    public Lecture(string title, string description, string date, string time, Address address,string eventType, string speakerName, int capacity) : base (title, description, date, time, address, eventType)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }
    private string _speakerName ;
    private int _capacity ;

    public string eventType ()
    {
        return "Lecture";
    }
}