using System;
using System.Collections.Generic;

public class Entry
{
        public List<string>_prompts = new List<string>();
        public void SaveEntry (string functionString) {

            _prompts.Add(functionString);
        }

        public string _journalPrompt ;
         
        public void DisplayP () 
        {
            foreach (string prompt in _prompts)
            {
            Console.WriteLine(prompt);
            }
        }
        
}

// Write a new entry - Show the user a random prompt 
// (from a list that you create), and save their response,

// the prompt, and the date as an Entry.
// Display the journal - Iterate through all entries in the 
// journal and display them to the screen.

// Save the journal to a file - Prompt the user for a filename 
// and then save the current journal (the complete list of entries) 
// to that file location.
// journal cs
// entry cs 
// program

// all attributes will be passed to the SaveNLoad
