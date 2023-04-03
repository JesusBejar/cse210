using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activityList = new List<Activity>();

        // Date, length of activity in minutes, distance of activity in km
        Running tenMinuteRun = new Running("Monday, April 3rd", 10, 5);
        _activityList.Add(tenMinuteRun);

        Biking hourLongRide = new Biking("Monday, April 4th", 60, 15);
        _activityList.Add(hourLongRide);

        Swimming thirtyMinuteSwim = new Swimming("Tuesday, April 5th", 30, 50);
        _activityList.Add(thirtyMinuteSwim);
        Console.Clear();
        foreach (Activity activity in _activityList)
        {
            activity.GetSummary(activity.ActivityType(), activity.DistanceCalculation(), activity.SpeedCalculation(), activity.PaceCalculation());
        }
        // finished
    }
}