using System;

class Program
{
    static void Main(string[] args)
    {
        // RECEPTION EVENT ----------
        Console.WriteLine("-----RECEPTION EVENT-----");
        Address a1 = new Address("333 E Wonderview Ave", "Colorado", "United States");
        Reception stanleyDance = new Reception("Ballroom dancing", "\nCome learn to dance at the Stanley Hotel!", "\nTuesday, April 4th", "\n6-10pm", a1, "Reception", "stanleyrsvp@gmail.com");
        stanleyDance.DisplayStandardDetails();
        // correct full & few details bug
        stanleyDance.DisplayFullDetails(stanleyDance.eventType(), stanleyDance.eventInfo());
        stanleyDance.DisplayFewDetails(stanleyDance.eventType());

        // LECTURE EVENT ----------
        Console.WriteLine("\n-----LECTURE EVENT-----");
        Address a2 = new Address("711 Oval Drive", "Colorado", "United States");
        Lecture csuDiscourse = new Lecture("Virtual talk: Indigenous Fire Stewardship in Canada", "\nFire Stewardship is important!", "\nThursday, April 6th", "\n10:45am", a2, "Lecture", "Amy Cardinal Christianson - 100 person capacity");
        csuDiscourse.DisplayStandardDetails();
        csuDiscourse.DisplayFullDetails(csuDiscourse.eventType(), csuDiscourse.eventInfo());
        csuDiscourse.DisplayFewDetails(csuDiscourse.eventType());

        // OUTDOOR EVENT ----------
        Console.WriteLine("\n-----OUTDOOR EVENT-----");
        Address a3 = new Address("3395 Cody Ln", "Wyoming","United States");
        Outdoor jacksonHoleParty = new Outdoor("Moose Hockey games", "\nPlay some outdoor ice hockey with us", "\nFriday, April 7th", "\n7pm", a2, "Outdoor", "Cloudy with a 5% chance of showers");
        jacksonHoleParty.DisplayStandardDetails();
        jacksonHoleParty.DisplayFullDetails(csuDiscourse.eventType(), jacksonHoleParty.eventInfo());
        jacksonHoleParty.DisplayFewDetails(csuDiscourse.eventType());
        
    }
}