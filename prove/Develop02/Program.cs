using System;

public class Program
{
    static void Main(string[] args)
    {
        // int randomNum = random.Next(0, _promptReference._questionPrompts.Count);
        // _promptReference.randomNum = randomNum;
            {
            string _userAnswer = null;

            string _displayedPrompt = null;

        while (_userAnswer != "5")
        {
            Console.WriteLine ("Please select one of the following choices");
            Console.WriteLine ("1) Write");
            Console.WriteLine ("2) Display");
            Console.WriteLine ("3) Load");
            Console.WriteLine ("4) Save");
            Console.WriteLine ("5) Quit");
            Console.WriteLine("What would you like to do? ");
            int _userChoice = int.Parse(Console.ReadLine());


            {
            if (_userChoice == 1)
            {
                PromptGenerator rp = new PromptGenerator();
                // populate prompt list
                rp.PopulatePromptList();
                // randomly generated prompt
                _displayedPrompt = rp.DisplayRandomPrompt();
                // user response
                Console.Write(">");
                _userAnswer = Console.ReadLine();

            }

            else if (_userChoice == 2)
            {
                Entry e = new Entry();
                DateTime todaysDate = DateTime.Today;

                e._date = todaysDate.ToString();
                e._userAnswer = _userAnswer;
                e._ranPrompt = _displayedPrompt;

                e.DisplayEntry();
            }
            else if (_userChoice == 3)
            {
                
            }
            else if (_userChoice == 4)
            {

            }
            else 
            {
                System.Environment.Exit(0); 
            }
        }
            
        }

    }
}
}