public class BaseActivity
{
    protected string _startingMessage ;
    protected string _openingPrompt ;
    public BaseActivity (string startingMessage, string openingPrompt) {
        _startingMessage = startingMessage;
        _openingPrompt = openingPrompt;
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