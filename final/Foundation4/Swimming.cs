public class Swimming : Activity
{
    private int _numOfLaps ;
    public Swimming (string date, int length, int counter, int numOfLaps) : base (date, length, counter)
    {
        _numOfLaps = numOfLaps;
    }
    public override int DistanceCalculation()
    {
        // Distance (km) = swimming laps * 50 / 1000
        return (((_numOfLaps) * 50) / 1000);
    }
    public override int SpeedCalculation()
    {
        // Speed (mph or kph) = (distance / minutes) * 60
        return ((((_numOfLaps) * 50 / 1000) / _length) * 60);
    }
    public override int PaceCalculation()
    {
        // Pace (min per mile or min per km)= minutes / distance
        return _length * ((_numOfLaps) * 50 / 1000);
    }
}