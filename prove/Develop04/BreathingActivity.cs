public class BreathingActivity : BaseActivity
{
    public BreathingActivity (string openingPrompt, string startingMessage, string closingMessage) : base (openingPrompt, startingMessage, closingMessage) 
    {
        
    }
    public void Breathe(int sec) {

        for (int a = sec / 5; a >= 0; a--)
        {
            Console.Write("\rBreathe in...{0:00}", a);
            System.Threading.Thread.Sleep(1000);
        } 
        for (int a = sec / 5; a >= 0; a--)
        {
            Console.Write("\rBreathe out...{0:00}", a);
            System.Threading.Thread.Sleep(1000);
        } 

    }
}