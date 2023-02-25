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
        int _userInt = Int32.Parse(_userMenuChoice);

        if (_userInt == 1) {
            BreathingActivity A1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing. :)", "Thank you for participating in the ");

            Console.WriteLine(A1.DisplayOpening());

            A1.Breathe(A1.GetSec());

            Console.Write(A1.DisplayClosing());
        }
        
        else if (_userInt == 2) {
            ReflectingActivity A2 = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. :)", "Thank you for participating in the ");

            Console.WriteLine(A2.DisplayOpening());

            A2.Reflect(A2.PopulateAndSelectPromptList(), A2.PopulateQuestionList(), A2.GetSec());

            Console.WriteLine(A2.DisplayClosing());
        }
        else if (_userInt == 3) {
            ListingActivity A3 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. :)", "Thank you for participating in the ");

            Console.WriteLine(A3.DisplayOpening());

            A3.GetSec();

            // fix pathway so that I can use Populate and Select Prompt List
            A3.List(A3.PopulateAndSelectPromptList(), A3.GetSec());

            A3.DotTimer();

            Console.WriteLine(A3.DisplayClosing());
        }
        else 
        {
            System.Environment.Exit(0); 
        }

    }
}