public class Running : Activity
{
    private string _distance ;
    public Running (string date, string length, int counter, string distance) : base (date, length, counter)
    {
        _distance = distance;
    }
    public override string DistanceCalculation()
    {
        return $"{_distance} km";
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