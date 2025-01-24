using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._company = "Google";
        job1._jobTitle = "supervisor";

        Job job2 = new Job();
        job2._company = "Valve";
        job2._jobTitle = "Artist";


        job1.Display();

    }
}