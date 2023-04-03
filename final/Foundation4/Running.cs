public class Running : Activity
{
    private int _distance ;
    public Running (string date, string length, int counter, int distance) : base (date, length, counter)
    {
        _distance = distance;
    }
    public override int DistanceCalculation()
    {
        return _distance;
    }
    // (distance / minutes) * 60
    public override string SpeedCalculation()
    {
        // 60 / pace
        return (((_distance / Int32.Parse(_length)) * 60).ToString());
    }
    public override string PaceCalculation()
    {
        // passes in length and distance
        // converts strings to ints
        // makes the calculation
        // converts ints to strings and returns
        return ((Int32.Parse(_length) * _distance).ToString());
    }
}