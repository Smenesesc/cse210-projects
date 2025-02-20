using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        var activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0),    // 3 miles run
            new Cycling(new DateTime(2022, 11, 3), 30, 15.0),    // 15 mph cycling speed
            new Swimming(new DateTime(2022, 11, 3), 30, 20)     // 20 laps swum
        };

        // Display the summary for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
