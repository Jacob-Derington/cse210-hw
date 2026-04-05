using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("\nHello Foundation4 World!\n");
        Console.Clear();

        // list
        List<Activity> activities = new List<Activity>();

        // the activities
        Running running = new Running("03 Nov 2025", 30, 3.0);
        Cycling cycling = new Cycling("04 Apr 2026", 10, 2.6);
        Swimming swimming = new Swimming("15 Apr 2026", 60, 6);

        // adds the activities to the list
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        // displies it
        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
        Console.WriteLine();
        
    }
}