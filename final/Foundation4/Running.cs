public class Running : Activity
{
    private string _distance ;
    public Running (string date, string length, int counter, List<Activity> activityList, string distance) : base (date, length, counter, activityList)
    {
        _distance = distance;
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