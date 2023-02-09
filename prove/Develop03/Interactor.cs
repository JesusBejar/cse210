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
        Console.WriteLine("Press enter to continue or type 'quit' to finish");
        if (Console.ReadKey().Key == ConsoleKey.Enter) {
            Console.WriteLine("enter was pressed");
            list.SplitScripture(scr.GetandSetScripture);
        }
        else {
            // List.SplitSentence();
            System.Environment.Exit(0);  
        }
        }
}