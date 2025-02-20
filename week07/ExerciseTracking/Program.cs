using System;

class Program
{
    static void Main(string[] args)
    {

        List<Activity> activities = [];

        Cycling cycling01 = new();
        cycling01.Initialize(20, 10);
        activities.Add(cycling01);

        Running running01 = new();
        running01.Initialize(15, 3);
        activities.Add(running01);

        Swimming swimming01 = new();
        swimming01.Initialize(2, 4);
        activities.Add(swimming01);


        foreach(Activity a in activities)
        {

            Console.WriteLine(a.GetSummary());

        }


    }
}