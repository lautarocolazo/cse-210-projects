using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Foundation 4, Lautaro G. Colazo" + Environment.NewLine);

        List<Activity> activities = new List<Activity>();

        Running r = new Running("01 Dec 2023", 30, 4.8);
        StationaryBike b = new StationaryBike("01 Dec 2023", 45, 15);
        Swimming s = new Swimming("01 Dec 2023", 10, 16);

        activities.Add(r);
        activities.Add(b);
        activities.Add(s);

        foreach (Activity activity in activities)
        {
            string summary = activity.GetSummary();
            Console.WriteLine(summary);
        }

        
    }
}
