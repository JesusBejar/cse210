public class Swimming : Activity
{
    private int _numOfLaps ;
    public Swimming (string date, int length, int counter, int numOfLaps) : base (date, length, counter)
    {
        _numOfLaps = numOfLaps;
    }
    public override int DistanceCalculation()
    {
        return ((_numOfLaps) * 50 / 1000);
    }
    public override int SpeedCalculation()
    {
        return (_length / ((_numOfLaps) * 50 / 1000) * 60);
    }
    public override int PaceCalculation()
    {
        return _length * ((_numOfLaps) * 50 / 1000);
    }
}