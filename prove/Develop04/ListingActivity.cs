public class ListingActivity : BaseActivity
{
    public ListingActivity(string openingPrompt, string startingMessage, string closingMessage) : base (openingPrompt, startingMessage, closingMessage) 
    {

    }
    public void List (string randomPrompt, int _sec) {
        Console.WriteLine("List as many responses as you can to the following prompt");
        Console.WriteLine($"\n ---{_randomPrompt}---");
        for (int _a = 5; _a >= 0; _a--)
            {
                Console.Write("\rYou may begin in: {0:00}", _a);
                System.Threading.Thread.Sleep(1000);
            }

        DateTime _startTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(_sec);
        Console.Write("\n");
        do {
        Console.Write(">");
        _userStr = Console.ReadLine();
        _counter +=1;
        }
        while (DateTime.Now < _endTime);

        Console.WriteLine($"You listed {_counter} items!");

        Console.WriteLine("Well done!");
        Console.WriteLine($"\nYou have completed {_sec} seconds of the {_activity}");
    }
}