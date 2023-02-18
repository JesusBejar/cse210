using System;

class Program
{
    static void Main(string[] args)
    {
        string _userMenuChoice ;

        Console.WriteLine("Menu Options");
        Console.WriteLine("1.Breathing Activity");
        Console.WriteLine("2.Reflecting Activity");
        Console.WriteLine("3.Listing Activity");
        Console.WriteLine("4.Quit");
        Console.WriteLine("Please select a choice from the menu: ");

        _userMenuChoice = Console.ReadLine();

        if (_userMenuChoice == "1") {
            BreathingActivity A2 = new BreathingActivity("Breathing Activity", "this is a prompt");

            Console.WriteLine(A2.DisplayPrompt());

            A2.DotTimer();

            A2.Breathe(A2.GetSec());
        }
        
        else if (_userMenuChoice == "2") {
            ReflectingActivity A3 = new ReflectingActivity("Reflecting Activity", "this is a prompt");

            Console.WriteLine(A3.DisplayPrompt());

            A3.DotTimer();
        }
        else if (_userMenuChoice == "3") {
            ListingActivity A4 = new ListingActivity("Listing Activity", "this is a prompt");

            Console.WriteLine(A4.DisplayPrompt());

            A4.DotTimer();
        }
        else 
        {
            System.Environment.Exit(0); 
        }

    }
}