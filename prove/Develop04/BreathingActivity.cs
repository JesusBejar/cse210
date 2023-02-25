public class BreathingActivity : BaseActivity
{
    public BreathingActivity (string openingPrompt, string startingMessage, string closingMessage) : base (openingPrompt, startingMessage, closingMessage) 
    {
        
    }
    public void Breathe(int sec) {
        Console.Write("Get ready");
        DotTimer();
        // will not function correctly with floats
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(sec);
        while (DateTime.Now < endTime) {
        for (int a = 5; a >= 0; a--)
        {
            Console.Write("\rBreathe in...{0:00}", a);
            System.Threading.Thread.Sleep(1000);

        } 
        for (int a = 5; a >= 0; a--)
        {
            Console.Write("\rBreathe out...{0:00}", a);
            System.Threading.Thread.Sleep(1000);

        } 
        _counter += 1;
        }
        Console.WriteLine($"\nYou have completed {sec} seconds of the {_activity}");

    }
}