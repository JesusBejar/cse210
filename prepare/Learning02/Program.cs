using System;

class Program
{
    static void Main(string[] args)
    {

        // the line below is an instance
        Job job1 = new Job();

        // The line below "interpolates" the strings
        // written in the Jobs.cs files
        // job1._title = "Yo Momma";

        job1._title = "Software engineer";
        job1._company = "The Church of Jesus Christ";
        job1._startYear = 2025;
        job1._endYear = 2030;

        // the line below "calls" and prints all job details -
        // company, title, start year, end year
        job1.DisplayDetails();

        // the line below "calls" and prints out
        // whatever is saved to the _company member variable
        // The Church of Jesus Christ
        // Console.WriteLine (job1._company);
        // Console.WriteLine(job1._company2);
        // Console.WriteLine(job1._title);

        // can arrays be "called" and referenced??
        // Console.WriteLine(job1._companies);

        // the lines below print out the same
        // results as job1.DisplayDetails();
        // Job job2 = new Job();
        // job2.DisplayDetails();
        // Job job3 = new Job();
        // job3.DisplayDetails();

        // another instance
        Job job2 = new Job();

        job2._title = "Data Scientist";
        job2._company = "Bloomberg";
        job2._startYear = 2025;
        job2._endYear = 2030;

        Resume resume = new Resume();

        resume._name = "Jesus Bejar";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        // why does the line below not work??
        // resume._jobs[0]._title();

        resume.DisplayDetails();

    }
}