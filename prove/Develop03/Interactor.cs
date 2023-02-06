using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

class Interactor
{
    private string _userInput;

    public void Decide() {
        Console.WriteLine("Press enter to continue or type 'quit' to finish");
        if (Console.ReadKey().Key == ConsoleKey.Enter) {
            System.Environment.Exit(0);  
        }
        else {
            // List.SplitSentence();
            Console.WriteLine("enter was pressed");
        }
        }
}