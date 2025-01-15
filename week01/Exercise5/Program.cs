using System;
using System.Globalization;


class Program
{

    static void DisplayWelcome()
    {

        Console.WriteLine("Welcome to the program!");

    }

    static String PromptUserName()
    {

        Console.Write("Please enter your name:  ");

        return Console.ReadLine();

    }

    static float PromptUserNumber()
    {

        Console.Write("Please enter your favorite number:  ");

        return float.Parse(Console.ReadLine());
        //I know someone's favorite number is probably an interger but you never know...

    }

    static float SquareNumber(float input)
    {

        return input * input;

    }

    static void DisplayResult(string name, float square)
    {

        Console.WriteLine($"{name}, the square of your favorite number is {square}.");

    }


    static void Main(string[] args)
    {
       DisplayWelcome();
       string name = PromptUserName();
       float num = PromptUserNumber();
       DisplayResult(name, SquareNumber(num));

    }
}