using System;

public class main
{

    static void Main(string[] args)
    {
        
        // below is an instance of the Journal class
        Journal _journalReference = new Journal();

        PromptGenerator _promptReference = new PromptGenerator();

        Random random = new Random();
        // below are the list of opening prompts that will 
        // be displayed when the user chooses option 1

        // below I am adding prompts to the the _questionPrompts list
        // they will be chosen at random and displayed to the user
        // with the help of the DisplayPrompt() method within the
        // StuffDisplayed class within the DisplayJournal file
        _promptReference._questionPrompts.Add("Who was the most interesting person I interacted with today?");
        _promptReference._questionPrompts.Add("What was the best part of my day?");
        _promptReference._questionPrompts.Add("Who are you more like, your mom or your dad?");
        _promptReference._questionPrompts.Add("What is your greatest joy");
        _promptReference._questionPrompts.Add("What is your greatest fear?");
        _promptReference._questionPrompts.Add("Why did you choose to study promming if it is so frustrating at times?");

        // below are the necessary references and variables to 
        // make a random number that will be used to display a 
        // random prompt to the user 
        int randomNum = random.Next(0, _promptReference._questionPrompts.Count);
        _promptReference.randomNum = randomNum;
        
        bool _continueJournal = true;

        while (_continueJournal == true) {

            Console.WriteLine ("Please select one of the following choices");
            Console.WriteLine ("1) Write");
            Console.WriteLine ("2) Display");
            Console.WriteLine ("3) Load");
            Console.WriteLine ("4) Save");
            Console.WriteLine ("5) Quit");
            Console.WriteLine("What would you like to do? ");
            int _userInput = int.Parse(Console.ReadLine());

            switch(_userInput) 
            {
            case 1:
                // Write
                _promptReference.DisplayPrompt();

                Console.Write(">");

                _promptReference._journalPrompt = Console.ReadLine();
                
                break;
            case 2:
                // Display
                break;
            case 3:
                // Save
                break;
            case 4:
                // Load
                break;
            case 5:
                // Quit
                    Console.WriteLine("See you soon!");
                    _continueJournal = false;
                break;
            }

        }

    }

}

// prompt1.SaveEntry(prompt1._journalPrompt);

// Write a new entry - Show the user a random prompt 
// (from a list that you create), and save their response,

// the prompt, and the date as an Entry.
// Display the journal - Iterate through all entries in the 
// journal and display them to the screen.

// Save the journal to a file - Prompt the user for a filename 
// and then save the current journal (the complete list of entries) 
// to that file location. 