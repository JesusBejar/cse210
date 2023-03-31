public class Lecture : Event
{
    public Lecture(string title, string description, string date, string time, Address address) : base (title, description, date, time, address)
    {

    }
    private string _speakerName ;
    private int _capacity ;

    public string eventType ()
    {
        return "Lecture";
    }
}