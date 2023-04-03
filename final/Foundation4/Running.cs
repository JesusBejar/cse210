public class Running : Activity
{
    private int _distance ;
    public Running (string date, int length, int counter, int distance) : base (date, length, counter)
    {
        _distance = distance;
    }
    public override double DistanceCalculation()
    {
        return _distance;
    }
    // Speed (mph or kph) = (distance / minutes) * 60
    public override double SpeedCalculation()
    {
        return ((_distance / _length) * 60);
    }
    public override double PaceCalculation()
    {
        // Pace (min per mile or min per km)= minutes / distance
        return (_length / _distance);
    }
    public override string ActivityType()
    {
        return "Running";
    }
}