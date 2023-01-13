using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        // Write is different from WriteLine
        // Write outputs beside the input message 
        // Writeline outputs underneath the input message
        string first_name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");

    }

}