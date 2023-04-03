public abstract class Activity
{
    public Activity (string date, int length, int counter)
    {
        _date = date;
        _length = length;
        _counter = counter;
    }
    protected string _date ; 
    protected int _length ;
    protected int _counter ;
    protected string _activityType ;
    public abstract int DistanceCalculation();
    public abstract int SpeedCalculation();
    public abstract int PaceCalculation();
    public abstract string ActivityType();

    // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    // make an abstract method for activity type
    public string GetSummary(string activityType, int distance, int speed, int pace)
    {
        Console.WriteLine($"Date: {_date} {activityType} ({_length} min) - Distance: {distance.ToString()}km Speed:{speed.ToString()}kph Pace:{pace.ToString()}min per km");
        return "";
    }
}