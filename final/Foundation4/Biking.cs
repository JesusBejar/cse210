public class Biking : Activity
{
    private int _speed ;
    public Biking (string date, int length, int counter, int speed) : base (date, length, counter)
    {
        _speed = speed;
    }
    public override int DistanceCalculation()
    {
        // (speed * minutes) * 60
        return ((_speed * _length) / 60);
    }
    public override int SpeedCalculation()
    {
        return _speed;
    }
    public override int PaceCalculation()
    {
        // Pace (min per mile or min per km)= minutes / distance
        return (_length / ((_speed * _length)));
    }
}