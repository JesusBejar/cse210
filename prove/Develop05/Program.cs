using System;

class Program
{
    static void Main(string[] args)
    {
        int _userMenuChoice ;

        List<string> _goals = new List<string>();

        // int _points ;

        do 
        {
        // Console.WriteLine($"You have {_points}");

        Console.WriteLine("\nMenu Options");
        Console.WriteLine("1.Create New Goal");
        Console.WriteLine("2.List Goals");
        Console.WriteLine("3.Save Goals");
        Console.WriteLine("4.Load Goals");
        Console.WriteLine("5.Record Event");
        Console.WriteLine("6.Quit");
        Console.WriteLine("Please select a choice from the menu: ");
        _userMenuChoice = Int32.Parse(Console.ReadLine());
        
        NewGoal ng = new NewGoal();

        if (_userMenuChoice == 1) {
            
            _goals.Add(ng.CancatenateGoal(ng.SpecificGoalTask()));
            
        }
        
        else if (_userMenuChoice == 2) {

            foreach (string g in _goals) 
            {
                Console.WriteLine(g);
            }
           
        }

        else if (_userMenuChoice == 3) {
            
        }

        else if (_userMenuChoice == 4) {
            
        }

        else if (_userMenuChoice == 5) {
            
        }
        
        else 
        {
            System.Environment.Exit(0); 
        }

        }
        while (_userMenuChoice != 6);
        
    }
}