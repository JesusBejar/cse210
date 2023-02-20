public class BreathingActivity : BaseActivity
{
    private int _counter ;
    public BreathingActivity (string openingPrompt, string startingMessage, string closingMessage) : base (openingPrompt, startingMessage, closingMessage) 
    {
        
    }
    public void Breathe(int sec) {
        Console.Write("Get ready");
        DotTimer();
        while (sec / 10 != _counter) {
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

    }
}