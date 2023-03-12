using System;
public class NewGoal : BaseGoal 
{
    public NewGoal(List<string> _goals) : base ( _goals)
    {

    }
    public override string SpecificGoalTask()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("1.Simple Goal");
        Console.WriteLine("2.Eternal Goal");
        Console.WriteLine("3.Checklist Goal");
        _userMenuChoice = Int32.Parse(Console.ReadLine());

        // Console.WriteLine(_userMenuChoice);
        if (_userMenuChoice == 1) 
            {
            // Console.WriteLine("O1");
            Console.WriteLine("What is the name of your goal?");
            _goalName = Console.ReadLine();
            Console.WriteLine("What is a short description of your goal?");
            _goalDescription = Console.ReadLine();
            Console.WriteLine("How many points do you want to assign to this goal?");
            _goalPoints = Int32.Parse(Console.ReadLine());
            return $"{_goalName} {_goalDescription} {_goalPoints}";
            }

        else if (_userMenuChoice == 2)
        {
            // Console.WriteLine("O2");
            Console.WriteLine("What is the name of your goal?");
            _goalName = Console.ReadLine();
            Console.WriteLine("What is a short description of your goal?");
            _goalDescription = Console.ReadLine();
            Console.WriteLine("How many points do you want to assign to this goal?");
            _goalPoints = Int32.Parse(Console.ReadLine());
            return $"{_goalName} {_goalDescription} {_goalPoints}";
        }

        else
        {
            // Console.WriteLine("O3");
            Console.WriteLine("What is the name of your goal?");
            _goalName = Console.ReadLine();
            Console.WriteLine("What is a short description of your goal?");
            _goalDescription = Console.ReadLine();
            Console.WriteLine("How many points do you want to assign to this goal?");
            _goalPoints = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How many times do you have to complete this goal to achieve a bonus?");
            _goalCount = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            _bonusPoints = Int32.Parse(Console.ReadLine());
            return $"{_goalName} {_goalDescription} {_goalPoints} {_goalCount} {_bonusPoints}";

        }
    }
    public string CancatenateGoal(string _line)
    {   
        return $" [ ] {_goalName} ({_goalDescription}) - {_goalPoints} points, Currently completed: {_goalCount} time(s)";
    }

}
