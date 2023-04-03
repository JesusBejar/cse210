using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activityList = new List<Activity>();

        Running tenMinuteRun = new Running("Monday, April 3rd", "10", 1, 5);
        tenMinuteRun.DistanceCalculation();
        tenMinuteRun.SpeedCalculation();
        tenMinuteRun.PaceCalculation();

        tenMinuteRun.GetSummary(
            tenMinuteRun.DistanceCalculation(),
            tenMinuteRun.SpeedCalculation(),
            tenMinuteRun.PaceCalculation()
        );

        
    }
}