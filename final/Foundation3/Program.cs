using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        Address a1 = new Address("333 E Wonderview Ave", "Colorado", "United States");

        Reception stanleyDance = new Reception("Ballroom dancing", "\nCome learn to dance at the Stanley Hotel!", "\nTuesday, April 4th", "\n6-10pm", a1, "Reception", "stanleyrsvp@gmail.com");
        stanleyDance.DisplayStandardDetails();
        stanleyDance.DisplayFullDetails(stanleyDance.eventType());
        stanleyDance.DisplayFewDetails();
        
    }
}