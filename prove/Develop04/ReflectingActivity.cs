public class ReflectingActivity : BaseActivity
{
    public ReflectingActivity(string openingPrompt, string startingMessage, string closingMessage) : base (openingPrompt, startingMessage, closingMessage) 
    {

    }
    private List<string> _randomPrompts = new List<string>();   
    private List<string> _randomQuestions = new List<string>();
        public string PopulateAndSelectPromptList() {
        var random = new Random();
        _randomPrompts.Add("Think of your closest people you trust.");
        _randomPrompts.Add("Describe a place where you felt happiest.");
        _randomPrompts.Add("Think of your favorite scripture.");
        _randomPrompts.Add("Describe yourself in a few words.");
        int index1 = random.Next(_randomPrompts.Count);
        _randomPrompt = _randomPrompts[index1].ToString();
        return _randomPrompt;
    }
    public string PopulateAndSelectQuestionList() {
        var random = new Random();
        _randomQuestions.Add("What answer did you give?");
        _randomQuestions.Add("How do your answer make you feel?");
        _randomQuestions.Add("Based on your answer, what do you think you should change in your life?");
        _randomQuestions.Add("What did you like or dislike about your answer?");
        int index2 = random.Next(_randomQuestions.Count);
        _randomQuestion = _randomQuestions[index2].ToString();
        return _randomQuestion;
    }

    public void Reflect(string randomPrompt, string randomQuestion, int sec) {
        Console.Write("\nGet ready");
        DotTimer();
        Console.WriteLine("\nConsider the following prompt: ");
        Console.WriteLine($"\n---{_randomPrompt}---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue");
        string _userInput = Console.ReadLine();
        if (_userInput != "word") {
            Console.WriteLine("Now ponder on each of the following question as they related to this experience.");
            for (int a = 5; a >= 0; a--)
            {
                Console.Write("\rYou may begin in: {0:00}", a);
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine($"\n{_randomQuestion}");
            DotTimer();
            Console.WriteLine($"\n{_randomQuestion}");
            DotTimer();
        }
        Console.WriteLine($"\nYou have completed {sec} seconds of the {_activity}");
    }
}
