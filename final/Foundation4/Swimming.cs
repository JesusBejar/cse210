public class Swimming : Activity
{
    private int _numOfLaps ;
    public Swimming (string date, int length, int counter, int numOfLaps) : base (date, length, counter)
    {
        _numOfLaps = numOfLaps;
    }
    public override int DistanceCalculation()
    {
        // converts _numOfLaps string to int
        // makes the calculation
        // converts int to string and returns
        return ((_numOfLaps) * 50 / 1000);
    }
    public override int SpeedCalculation()
    {
        return (_length / ((_numOfLaps) * 50 / 1000) * 60);
    }
    public override int PaceCalculation()
    {
        // passes in length and distance
        // converts strings to ints
        // makes the calculation
        // converts ints to strings and returns
        return _length * ((_numOfLaps) * 50 / 1000);
    }
}