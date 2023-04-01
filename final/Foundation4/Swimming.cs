public class Swimming : Activity
{
    private string _numOfLaps ;
    public Swimming (string date, string length, int counter, List<Activity> activityList, string numOfLaps) : base (date, length, counter, activityList)
    {
        _numOfLaps = numOfLaps;
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