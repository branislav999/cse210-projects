using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        
        Running runningActivity = new Running("11/10/2023", 30, 3.0);
        Bicycle bicycleActivity = new Bicycle("11/10/2023", 30, 15.0);
        Swimming swimmingActivity = new Swimming("11/10/2023", 30, 10);

        
        activities.Add(runningActivity);
        activities.Add(bicycleActivity);
        activities.Add(swimmingActivity);

        
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
