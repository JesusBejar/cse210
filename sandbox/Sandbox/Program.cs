using System;
using System.Collections.Generic;

class P
{
    static void Main(string[] args)
    {
        Entry prompt1 = new Entry();

        Console.WriteLine("Please write a journal prompt: ");

        prompt1._journalPrompt = Console.ReadLine();

        Console.WriteLine(prompt1._journalPrompt);
        // above displays _journalPrompts attribute

        prompt1.SaveEntry(prompt1._journalPrompt);

        // var random = new Random();

        // int index = random.Next(promptList.Count);

        // Console.WriteLine(promptList[index]);
        
        prompt1.DisplayP();

        
    }
}