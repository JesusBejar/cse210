using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("333 E Wonderview Ave", "Colorado", "United States");

        Reception stanleyDance = new Reception("Ballroom dancing", "\nCome learn to dance at the Stanley Hotel!", "\nTuesday, April 4th", "\n6-10pm", a1, "Reception", "stanleyrsvp@gmail.com");
        stanleyDance.DisplayStandardDetails();
        stanleyDance.DisplayFullDetails(stanleyDance.eventType());
        stanleyDance.DisplayFewDetails();

        Address a2 = new Address("711 Oval Drive", "Colorado", "United States");

        Lecture csuDiscourse = new Lecture("Amy Cardinal Christianson virtual talk: Indigenous Fire Stewardship in Canada", "\nFire Stewardship is important!", "\nThursday, April 6th", "\n10:45pm", a2, "Lecture", "katy.stites@colostate.edu", 100);
        csuDiscourse.DisplayStandardDetails();
        csuDiscourse.DisplayFullDetails(csuDiscourse.eventType());
        csuDiscourse.DisplayFewDetails();
        
    }
}