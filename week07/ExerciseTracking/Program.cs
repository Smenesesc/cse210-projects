using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of each activity
        Running run = new Running("03 Nov 2022", 30, 3.0);
        Cycling cycle = new Cycling("03 Nov 2022", 45, 15.0);
        Swimming swim = new Swimming("03 Nov 2022", 60, 30);

        // Storing all activities in a list
        List<Activity> activities = new List<Activity> { run, cycle, swim };

        // Iterating through the activities and displaying their summary
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
