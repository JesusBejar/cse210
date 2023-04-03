public class Biking : Activity
{
    private double _speed ;
    public Biking (string date, int length, int counter, int speed) : base (date, length, counter)
    {
        _speed = speed;
    }
    public override double DistanceCalculation()
    {
        // (speed * minutes) * 60
        return ((_speed * _length) / 60);
    }
    public override double SpeedCalculation()
    {
        return _speed;
    }
    public override double PaceCalculation()
    {
        // doesn't appear
        // Pace (min per mile or min per km)= minutes / distance
        return (_length / ((_speed * _length)));
    }
    public override string ActivityType()
    {
        return "Biking";
    }
}