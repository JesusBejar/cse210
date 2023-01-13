using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        List <int> numbers = new List<int> ();

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        int userNums = -1;

        while (userNums != 0) {
            Console.Write("Enter a number!: ");
            string userStrs = Console.ReadLine();

            userNums = int.Parse(userStrs);

            // add parsed, int numbers to numbers list
            numbers.Add(userNums);
        }

        // used to make sure userNums was being added to List
        // foreach (int number in numbers) {
        //     Console.WriteLine($"{number}");
        // }

        // this is the Sum function 
        // data type variableName = listName.Sum();
        int sum = numbers.Sum();
        Console.WriteLine($"This is the sum {sum} ");

        // this is called the Enumerable.Average method
        // double average = listName.Average();
        double average = numbers.Average();
        Console.WriteLine($"This is the average {average}");

        int max = numbers[0];

        foreach (int number in numbers) 
        {
            if ( number > max)
            {
                max = number;
            }

            
        }

        Console.WriteLine($"This is the max {max}");
    }
}