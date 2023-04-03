public class Running : Activity
{
    private int _distance ;
    public Running (string date, int length, int counter, int distance) : base (date, length, counter)
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
        Console.WriteLine(_distance);
        Console.WriteLine(_length);
        return (((_distance / _length) * 60).ToString());
    }
    public override string PaceCalculation()
    {
        // passes in length and distance
        // converts strings to ints
        // makes the calculation
        // converts ints to strings and returns
        return (_length / _distance).ToString();
    }
}