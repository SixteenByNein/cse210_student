using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        Job job0 = new Job();

        job0._company = "Porsche";
        job0._jobTitle = "Graphic Designer";
        job0.startYear = 2013;
        job0._endYear = 2020;

        Job job1 = new Job();

        job1._company = "LEGO";
        job1._jobTitle = "Master Builder";
        job1.startYear = 2020;
        job1._endYear = 2025;

        Resume resume1 = new Resume();
        resume1._name = "Gunnar Young";
        
        resume1._jobs.Add(job0);
        resume1._jobs.Add(job1);

        resume1.Display();


    }
}