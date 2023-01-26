public class PromptGenerator
{   
    public string _journalPrompt ;

    public string _currentDate;

    public int randomNum;

    public List<string> _questionPrompts = new List<string>();
    public void DisplayPrompt() 
    {
        Console.WriteLine(_questionPrompts[randomNum]);
    }

}


            // write and read into journal files

            // responsibilites :
            // write
            // display (DateOnly + journal)
            // iterate

            // variables :
            // userInput
            // UserList (public List<Job>_jobs = new List<Job>();