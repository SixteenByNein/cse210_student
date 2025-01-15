using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name?  --  ");
        string givenN = Console.ReadLine();

        Console.Write("What is your last name?  --  ");
        string surN = Console.ReadLine();

        Console.WriteLine($"Your name is {surN}, {givenN} {surN}.");

    }
}