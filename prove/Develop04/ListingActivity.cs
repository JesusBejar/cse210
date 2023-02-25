public class ListingActivity : BaseActivity
{
    public ListingActivity(string openingPrompt, string startingMessage, string closingMessage) : base (openingPrompt, startingMessage, closingMessage) 
    {

    }
    public void List (string randomPrompt, int sec) {
        Console.WriteLine("List as many responses as you can to the following prompt");
        Console.WriteLine($"\n ---{_randomPrompt}---");
        for (int a = 5; a >= 0; a--)
            {
                Console.Write("\rYou may begin in: {0:00}", a);
                System.Threading.Thread.Sleep(1000);
            }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(sec);
        Console.Write("\n");
        do {
        Console.Write(">");
        _userStr = Console.ReadLine();
        _counter +=1;
        }
        while (DateTime.Now < endTime);

        Console.WriteLine($"You listed {_counter} items!");

        Console.WriteLine($"\nYou have completed {sec} seconds of the {_activity}");
    }
}