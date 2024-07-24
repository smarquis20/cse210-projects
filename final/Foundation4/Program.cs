using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("24 Jul 2024", 30, 3.0d);
        Cycling cycling = new Cycling("13 Jul 2024", 30, 16.0d);
        Swimming swimming = new Swimming("07 Jul 2024", 15, 30);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}