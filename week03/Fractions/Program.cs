using System;

class Program
{

    static void Main(string[] args)
    {

        Fraction frac = new Fraction();

        frac.SetTop(3);
        frac.SetBottom(5);

        Console.WriteLine(frac.GetTop());
        Console.WriteLine(frac.GetBottom());
        Console.WriteLine(frac.GetFractionString());
        Console.WriteLine(frac.GetDecimalValue());

    }
}