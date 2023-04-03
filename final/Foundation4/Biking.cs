public class Biking : Activity
{
    private int _speed ;
    public Biking (string date, int length, int counter, int speed) : base (date, length, counter)
    {
        _speed = speed;
    }
    public override int DistanceCalculation()
    {
        return ((_speed * _length) / 60);
    }
    // (distance / minutes) * 60
    public override int SpeedCalculation()
    {
        return _speed;
    }
    public override int PaceCalculation()
    {
        return (_length / ((_speed * _length)));
    }
}