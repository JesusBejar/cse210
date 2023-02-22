public class ReflectingActivity : BaseActivity
{
    public ReflectingActivity(string openingPrompt, string startingMessage, string closingMessage) : base (openingPrompt, startingMessage, closingMessage) 
    {

    }
    private List<string> _randomPrompts = new List<string>();
    public string PopulateAndSelect() {
        var random = new Random();
        _randomPrompts.Add("What brings you joy?");
        _randomPrompts.Add("Describe a place where you felt happiest.");
        _randomPrompts.Add("What was your greatest fear, and how did you conquer it?");
        _randomPrompts.Add("What is something that you would like to change about yourself?");
        int index = random.Next(_randomPrompts.Count);
        _randomPrompt = _randomPrompts[index].ToString();
        return _randomPrompt;
    }

    public void Reflect(string randomPrompt) {
        Console.Write("Get ready");
        DotTimer();
        Console.WriteLine("\nConsider the following prompt: ");
        Console.WriteLine($"---{_randomPrompt}---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue");
        
        Console.WriteLine("Now ponder on each of the following question as they related to this experience.");
        for (int a = 5; a >= 0; a--)
        {
            Console.Write("\rYou may begin in: {0:00}", a);
            System.Threading.Thread.Sleep(1000);

        } 
    }
}
