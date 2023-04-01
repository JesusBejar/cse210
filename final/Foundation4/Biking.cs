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
    public override string PaceCalculation()
    {
        return "";
    }
}