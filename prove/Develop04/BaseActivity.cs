public class BaseActivity
{
    protected string _startingMessage ;
    protected string _openingPrompt ;
    private string _userSecStr ;
    public BaseActivity (string startingMessage, string openingPrompt) {
        _startingMessage = startingMessage;
        _openingPrompt = openingPrompt;
    }
    public int GetSec() 
    {
        Console.WriteLine("How long, in seconds, would you like for your session? ");

        _userSecStr = Console.ReadLine();

        int _userSecInt = Int32.Parse(_userSecStr);

        return _userSecInt;
    }

    public string DisplayPrompt() {
        return $"{_startingMessage}\n{_openingPrompt}\n";
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