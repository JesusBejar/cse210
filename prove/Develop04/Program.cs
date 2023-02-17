using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        BaseActivity A1 = new BaseActivity("this is a message", "this is a prompt");

        Console.WriteLine(A1.DisplayPrompt());

        BreathingActivity A2 = new BreathingActivity("Breathing Activity", "this is a prompt");

        Console.WriteLine(A2.DisplayPrompt());

        ReflectingActivity A3 = new ReflectingActivity("Reflecting Activity", "this is a prompt");

        Console.WriteLine(A3.DisplayPrompt());

        ListingActivity A4 = new ListingActivity("Listing Activity", "this is a prompt");

        Console.WriteLine(A4.DisplayPrompt());
    }
}