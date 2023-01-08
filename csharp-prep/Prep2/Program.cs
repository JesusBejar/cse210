using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade: ");
        string userGrade = Console.ReadLine();

        int x = int.Parse(userGrade);

        string letter = "";

        if (x >= 90)
        {
            letter = ("A");

            Console.WriteLine($"Your grade is {letter}");
        }
        else if (x >= 80)
        {
            letter = ("B");

            Console.WriteLine($"Your grade is {letter}");
        }
        else if (x >= 70)
        {
            letter = ("C");

            Console.WriteLine($"Your grade is {letter}");
        }
        else if (x >= 60)
        {
            letter = ("D");

            Console.WriteLine($"Your grade is {letter}");
        }
        else 
        {
            letter = ("F");

            Console.WriteLine($"Your grade is {letter}");
        }
        if (x >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else 
        {
            Console.WriteLine("Study so you can pass the class with a grade of 70 or more");
        }

        Console.WriteLine($"Your grade is {letter}");

    }
}