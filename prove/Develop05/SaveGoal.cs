class SaveGoal : BaseGoal 
{
    public SaveGoal(List<string> _goals) : base ( _goals)
    {
        
    }
    public override string SpecificGoalTask()
    {
        Console.WriteLine("Please enter the name of your file:");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"Points : {_goalPoints}");

            foreach (string g in _goals) 
            {
                outputFile.WriteLine($"{g}");
            }
        }
        _goals.Clear();
        Console.WriteLine("Goals have been cleared");
        Console.Clear();
        return ""; 
    }
}