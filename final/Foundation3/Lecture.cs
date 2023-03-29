public class Leture : Event
{
    public Lecture(string speakerName, int capacity)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }
    private string _speakerName ;
    private int _capacity ;
}