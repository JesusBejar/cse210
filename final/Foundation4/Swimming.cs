public class Swimming : Activity
{
    private string _numOfLaps ;
    public Swimming (string date, string length, int counter, string numOfLaps) : base (date, length, counter)
    {
        _numOfLaps = numOfLaps;
    }
    public override string DistanceCalculation()
    {
        // converts _numOfLaps string to int
        // makes the calculation
        // converts int to string and returns
        return (Int32.Parse(_numOfLaps) * 50 / 1000).ToString();
    }
    public override string SpeedCalculation()
    {
        return "";
    }
    public override string PaceCalculation(string length, string distance)
    {
        // passes in length and distance
        // converts strings to ints
        // makes the calculation
        // converts ints to strings and returns
        return ((Int32.Parse(length) * Int32.Parse(distance)).ToString());
    }
}