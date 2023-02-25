public class ReflectingActivity : BaseActivity
{
    public ReflectingActivity(string openingPrompt, string startingMessage, string closingMessage) : base (openingPrompt, startingMessage, closingMessage) 
    {

    }
    private List<string> _randomQuestions = new List<string>();
    private List<int> _selectedQuestions = new List<int>();
    private string _selectedQuestion ;
    private int _index ;
    public List<string> PopulateQuestionList() {
        _randomQuestions.Add("What was your answer?");
        _randomQuestions.Add("How does your answer make you feel?");
        _randomQuestions.Add("Do you feel your answer was positive or negative? Why?");
        _randomQuestions.Add("Based on your answer, what do you think you should change in your life?");
        _randomQuestions.Add("What did you like or dislike about your answer?");
        _randomQuestions.Add("What did you learn from your answer?");
        // move index code snippet into reflect(); function - Bryce 
        // use List<str> name.contains() to filter through a list and check if random question is within list - Abraham
        return _randomQuestions;
    }
    private string SelectRandomQuestion() {
        if (_selectedQuestions.Count != _randomQuestions.Count) {
            return Random();
        } else {
            _selectedQuestions.Clear();
            return Random();
        }
    }
    public string Random() {
        do {
            var _random = new Random();
            _index = _random.Next(_randomQuestions.Count);
        }while(_selectedQuestions.Contains(_index));
            _selectedQuestions.Add(_index);
            return _selectedQuestion = _randomQuestions[_index];
    }
    public void Reflect(string randomPrompt, List<string> randomQuestions, int _sec) {
        // _randomQuestion = _randomQuestions[index].ToString();
        PopulateQuestionList();
        Console.Write("\nGet ready");
        DotTimer();
        Console.WriteLine("\nConsider the following prompt: ");
        Console.WriteLine($"\n---{_randomPrompt}---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue");
        string _userInput = Console.ReadLine();
        DateTime _startTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(_sec);
        if (_userInput != "word") {
            Console.WriteLine("Now ponder on each of the following question as they related to this experience.");
            for (int _a = 5; _a >= 0; _a--)
            {
                Console.Write("\rYou may begin in: {0:00}", _a);
                System.Threading.Thread.Sleep(1000);
            }
            do {
                Console.WriteLine("\n");
                Console.WriteLine(SelectRandomQuestion());
                DotTimer();
                _counter +=1;
            }while (DateTime.Now < _endTime);
            
        }
        Console.WriteLine("Well done!");
        Console.WriteLine($"\nYou have completed {_sec} seconds of the {_activity}");
    }
}
