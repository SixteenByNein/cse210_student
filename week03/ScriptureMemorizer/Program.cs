using System;

class Program
{

    static void Main(string[] args)
    {

        Reference moroniRef = new Reference();

        moroniRef.InitializeRef();

        Scripture moroni = new Scripture();

        moroni.SetRef(moroniRef);

        moroni.SetWords("Yea, verily, verily I say unto you, if all men had been, and were, and ever would be, like unto Moroni, behold, the very powers of hell would have been shaken forever; yea, the devil would never have power over the hearts of the children of men.");


        Console.WriteLine(moroni.GetDisplayText());
    }
}