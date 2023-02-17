public class BaseActivity
{
    protected string _startingMessage ;
    protected string _openingPrompt ;
    private int sec ;
    private int _userMenuChoice ;

    public BaseActivity (string startingMessage, string openingPrompt) {
        _startingMessage = startingMessage;
        _openingPrompt = openingPrompt;
    }

    public string DisplayPrompt() {
        return $"{_startingMessage}\n{_openingPrompt}\n";
    }

}