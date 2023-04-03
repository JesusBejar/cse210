public abstract class Activity
{
    public Activity (string date, string length, int counter)
    {
        _date = date;
        _length = length;
        _counter = counter;
    }
    protected string _date ; 
    protected string _length ;
    protected int _counter ;
    public abstract int DistanceCalculation();
    public abstract string SpeedCalculation();
    public abstract string PaceCalculation();

    // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    // make an abstract method for activity type
    public string GetSummary(int distance, string speed, string pace)
    {
        Console.WriteLine($"Date: {_date} ({_length} min) - Distance: {distance.ToString()}km Speed:{speed}kph Pace:{pace}min per km");
        return "";
    }
}