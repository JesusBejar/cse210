public class PromptGenerator
{   
    public string _ranPrompt ;
    public int _ranNum ;
    public List<string> _promptList = new List<string>();
    public void PopulatePromptList()
    {
        _promptList.Add("Who was the most interesting person I interacted with today?");
        _promptList.Add("What was the best part of my day?");
        _promptList.Add("How did I see the hand of the Lord in my life today?");
        _promptList.Add("What was the strongest emotion I felt today?");
        _promptList.Add("If I had one thing I could do over today, what would it be?");
    }
    public string DisplayRandomPrompt() 
    {
        Random random = new Random();
        _ranNum = random.Next(_promptList.Count());
        _ranPrompt = _promptList[_ranNum];
        Console.WriteLine($"{_ranPrompt}");
        return $"{_ranPrompt}";
    }
}
