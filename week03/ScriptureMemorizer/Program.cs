using System;
using System.Collections.Immutable;

class Program
{

    static void Main(string[] args)
    {

        bool quit = false;


        //CREATIVITY: Here, I give the user the option to have the first letter of each word.

        Console.Write("Type '1' for default mode. Type '2' for first letter mode.");

        bool mode = Console.ReadLine() == "2";




        Reference moroniRef = new Reference();

        moroniRef.InitializeRef();

        Scripture moroni = new Scripture();

        moroni.SetRef(moroniRef);

        moroni.SetWords("Yea, verily, verily I say unto you, if all men had been, and were, and ever would be, like unto Moroni, behold, the very powers of hell would have been shaken forever; yea, the devil would never have power over the hearts of the children of men.");

        Console.WriteLine(moroni.GetDisplayText(mode));


        while (!quit)
        {

            quit = Console.ReadLine() == "quit";

            if(moroni.HideRandomWords(3))
            {

                Console.WriteLine(moroni.GetDisplayText(mode));

                quit = Console.ReadLine() == "quit";

                Console.Clear();

                Console.WriteLine("Well done, good and faithful servant.");

            } else{

            Console.WriteLine(moroni.GetDisplayText(mode));

            }


        }

        //fun little signoff

        Console.WriteLine("Brethren, adeu.");

    }
}