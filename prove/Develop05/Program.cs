using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> _goals = new List<string>();

        int _userMenuChoice ;

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
        
        NewGoal ng = new NewGoal(_goals);
        ListGoal lg = new ListGoal(_goals);
        SaveGoal sg = new SaveGoal(_goals);
        LoadGoal llg = new LoadGoal(_goals);
        Record r = new Record(_goals);

        if (_userMenuChoice == 1) {
            
            _goals.Add(ng.CancatenateGoal(ng.SpecificGoalTask()));
        }
        
        else if (_userMenuChoice == 2) {
           lg.SpecificGoalTask();
        }

        else if (_userMenuChoice == 3) {

            sg.SpecificGoalTask();
        }

        else if (_userMenuChoice == 4) {
            llg.SpecificGoalTask();
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