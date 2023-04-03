public abstract class Activity
{
    public Activity (string date, int length, int counter)
    {
        _date = date;
        _length = length;
        _counter = counter;
    }
    protected string _date ; 
    protected double _length ;
    protected int _counter ;
    protected string _activityType ;
    public abstract double DistanceCalculation();
    public abstract double SpeedCalculation();
    public abstract double PaceCalculation();
    public abstract string ActivityType();

    // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    // make an abstract method for activity type
    public string GetSummary(string activityType, double distance, double speed, double pace)
    {
        Console.WriteLine($"Date: {_date} Activity Type: {activityType} ({_length} min) - Distance: {distance.ToString()}km Speed: {speed.ToString()}kph Pace: {pace.ToString("F2")}min/km");
        return "";
    }
}