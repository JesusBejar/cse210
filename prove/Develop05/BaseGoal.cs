public abstract class BaseGoal 
{
    protected int _userMenuChoice ;
    protected string _goalName ;
    protected string _goalDescription ;
    protected int _goalPoints ;
    protected int _bonusPoints ;
    protected int _counter ;
    // protected List<string> _goals ;

    public abstract string SpecificGoalTask();
    public string DisplayLevelUp() 
    {
        if (_goalPoints > 500)  {
            return"Congrats! You leveled up! \n You current level is 1";
        }
        else if (_goalPoints > 100)  {
            return "Congrats! You leveled up! \n You current level is 2";
        }    
        else if (_goalPoints > 1500)  {
            return"Congrats! You leveled up! \n You current level is 3";
        }  
        // be sure to change this last else statement
        else { return "1";} 

    }

}