public abstract class Activity
{
    private string _date ; 
    private string _length ;
    private int _counter ;
    private List<Activity> _activityList ;

    public abstract string DistanceCalculation();
}