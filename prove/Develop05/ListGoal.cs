public class ListGoal : BaseGoal 
{
    public ListGoal(List<string> _goals) : base ( _goals)
    {
        
    }
    public override string SpecificGoalTask()
    {

        foreach (string g in _goals) 
        {
            Console.Write(_goals.IndexOf(g)+1);
            Console.WriteLine(g);
        }
        return "";
    }
}