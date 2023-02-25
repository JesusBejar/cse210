public class BaseActivity
{
    protected string _activity ;
    protected string _openingPrompt ;
    protected string _userStr ;
    protected int _userSecInt ;
    protected string _closingMessage ;
    protected string _randomPrompt ;
    protected string _randomQuestion;
    protected int _counter ;
    protected List<string> _randomPrompts = new List<string>();   
    
    public BaseActivity (string activity, string openingPrompt, string closingMessage) {
        _activity = activity;
        _openingPrompt = openingPrompt;
        _closingMessage = closingMessage;
    }
    public int GetSec() 
    {
        Console.WriteLine("How long, in seconds, would you like for your session? ");

        _userStr = Console.ReadLine();

        int _userSecInt = Int32.Parse(_userStr);

        return _userSecInt;
    }

    public string DisplayOpening() {
        return $"Welcome to the {_activity}\n{_openingPrompt}\n";
    }
    public string DisplayClosing() {
        return $"\n{_closingMessage}{_activity}";
    }

    public void DotTimer()
            {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(".");

                Thread.Sleep(1000);

                Console.Write(".");

                Thread.Sleep(1000);

                Console.Write(".");

                Thread.Sleep(1000);

                Console.Write("\b \b"); // Erase the + character
                Console.Write("\b \b"); // Erase the + character
                Console.Write("\b \b"); // Erase the + character

            }

        }
    public string PopulateAndSelectPromptList() {
            var random = new Random();
            _randomPrompts.Add("Think of (or write down) the closest people you trust.");
            _randomPrompts.Add("Describe a place where you felt happiest.");
            _randomPrompts.Add("Think of (or write down) your favorite scripture.");
            _randomPrompts.Add("Describe yourself in a few words.");
            int index1 = random.Next(_randomPrompts.Count);
            _randomPrompt = _randomPrompts[index1].ToString();
            return _randomPrompt;
        }
    }