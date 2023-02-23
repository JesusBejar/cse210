public class BaseActivity
{
    protected string _activity ;
    protected string _openingPrompt ;
    private string _userSecStr ;
    protected string _closingMessage ;
    protected string _randomPrompt ;
    protected string _randomQuestion;
    
    public BaseActivity (string activity, string openingPrompt, string closingMessage) {
        _activity = activity;
        _openingPrompt = openingPrompt;
        _closingMessage = closingMessage;
    }
    public int GetSec() 
    {
        Console.WriteLine("How long, in seconds, would you like for your session? ");

        _userSecStr = Console.ReadLine();

        int _userSecInt = Int32.Parse(_userSecStr);

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

}