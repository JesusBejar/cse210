public abstract class Activity
{
    public Activity (string date, string length, int counter, List<Activity> activityList)
    {
        _date = date;
        _length = length;
        _counter = counter;
        _activityList = activityList;
    }
    private string _date ; 
    private string _length ;
    private int _counter ;
    private List<Activity> _activityList ;

    public abstract string DistanceCalculation();
    public abstract string SpeedCalculation();
    public abstract string PaceCalculation();
}