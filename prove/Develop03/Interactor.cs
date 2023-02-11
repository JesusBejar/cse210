using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

class Interactor
{

    List list = new List();
    Scripture scr = new Scripture();

  public void Decide() {
    for (int i=0;i<36;i++) 
    {
        Console.WriteLine("Press enter to continue or type 'quit' to finish");
        string _userInput = Console.ReadLine();
        if (_userInput == "quit") {
            // List.SplitSentence();
            System.Environment.Exit(0);  
        }
        else if (_userInput != "quit") {
            // Console.ReadKey().Key == ConsoleKey.Enter
            list.SplitScripture(scr.GetandSetScripture);
        }    
    }
    }
}