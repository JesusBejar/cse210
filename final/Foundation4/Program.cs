using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activityList = new List<Activity>();

        Running tenMinuteRun = new Running("Monday, April 3rd", 10, 1, 5);
        tenMinuteRun.DistanceCalculation();
        tenMinuteRun.SpeedCalculation();
        tenMinuteRun.PaceCalculation();
        _activityList.Add(tenMinuteRun);

        Biking hourLongRide = new Biking("Monday, April 4th", 60, 1, 15);
        hourLongRide.DistanceCalculation();
        hourLongRide.SpeedCalculation();
        hourLongRide.PaceCalculation();
        _activityList.Add(hourLongRide);

        Swimming thirtyMinutes = new Swimming("Tuesday, April 5ht", 30, 1, 10);
        thirtyMinutes.DistanceCalculation();
        thirtyMinutes.SpeedCalculation();
        thirtyMinutes.PaceCalculation();
        _activityList.Add(thirtyMinutes);

        foreach (Activity activity in _activityList)
        {
            activity.GetSummary(activity.DistanceCalculation(), activity.SpeedCalculation(), activity.PaceCalculation());
        }
    }
}