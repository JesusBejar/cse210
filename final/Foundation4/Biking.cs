public class Biking : Activity
{
    private string _speed ;
    public Biking (string date, string length, int counter, List<Activity> activityList, string speed) : base (date, length, counter, activityList)
    {
        _speed = speed;
    }
    public override string DistanceCalculation()
    {
        return "";
    }
    public override string SpeedCalculation()
    {
        return "";
    }
    public override string PaceCalculation(string length, string distance)
    {
        // passes in length and distance
        // converts strings to ints
        // makes the calculation
        // converts ints to strings and returns
        return ((Int32.Parse(length) * Int32.Parse(distance)).ToString());
    }
}