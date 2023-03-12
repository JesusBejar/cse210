public abstract class BaseGoal 
{
    // below is the global varible that represents the user's menu choices
    protected int _userMenuChoice ;
    // below is the varible that stores the goal name
    protected string _goalName ;
    // below is the varible that stores the goal description
    protected string _goalDescription ;
    // below is the varible that stores goal points
    protected int _goalPoints ;
    // // below is the varible that stores the number of bonus points for option # 1-3
    protected int _bonusPoints ;
    // below is the varible that stores the inicial amount of times a goal must be completed
    protected int _goalCount ;
    // below is the varible that stores the amount of times a goal has been completed
    protected int _repetitions ;
    // below is the list of goals made (this will reference the one if program)
    protected List<string> _goals ;
    // below is a constructor that passes the _goals list to all classes
    public BaseGoal(List<string> goals)
    {
        _goals = goals;
    }
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