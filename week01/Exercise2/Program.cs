using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter percent grade:");
        float percent = float.Parse(Console.ReadLine());

        //This part is just for fun. The article changes between "a" and "an" based on the letter.
        string article;
        
        string letterGrade;

        if (percent >= 90)
        {

            article = "an";
            letterGrade = "A";

        } else if (percent >= 80)
        {

            article = "a";
            letterGrade = "B";

        } else if (percent >= 70)
        {

            article = "a";
            letterGrade = "C";

        } else if (percent >= 60)
        {

            article = "a";
            letterGrade = "D";

        } else 
        {

            article = "an";
            letterGrade = "F";

        }





        string sign;

        Console.WriteLine($"{percent % 10}");

        if (percent % 10 >= 7 && percent < 90 && percent > 60){

            sign = "+";

        } else if (percent % 10 < 3 && percent > 60){

            sign = "-";

        } else
        {

            sign = "";

        }



        //The following is also just for fun. If your grade is B or higher, the punctuation changes to a single exclamation mark to show excitment.
        //If the grade is an F+ or lower, the puntuation becomes three exclamation marks to show worry. 
        //Otherwise, the punctuation is a single period.

        string punctuation;

        if (percent >= 80)
        {

            punctuation = "!";

        } else if (percent < 60)
        {

            punctuation = "!!!";

        } else
        {

            punctuation = ".";

        }





        Console.WriteLine($"The letter grade is {article} {letterGrade}{sign}{punctuation}");

    }
}