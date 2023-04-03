public class Swimming : Activity
{
    private double _numOfLaps ;
    public Swimming (string date, int length, int numOfLaps) : base (date, length)
    {
        _numOfLaps = numOfLaps;
    }
    public override double DistanceCalculation()
    {
        // Distance (km) = swimming laps * 50 / 1000
        return (((_numOfLaps) * 50) / 1000);
    }
    public override double SpeedCalculation()
    {
        // Speed (mph or kph) = (distance / minutes) * 60
        return ((((_numOfLaps) * 50 / 1000) / _length) * 60);
    }
    public override double PaceCalculation()
    {
        // Pace (min per mile or min per km)= minutes / distance
        return _length * ((_numOfLaps) * 50 / 1000);
    }
    public override string ActivityType()
    {
        return "Swimming";
    }
}