using System;

class Program
{
    static void Main(string[] args)
    {

        bool playAgain = true;

        do{

            int count = 0;

            Random randomGen = new Random();
            int magic = randomGen.Next(1,100);

            int guess;

            do{

            Console.WriteLine("Guess the magic number!");
            guess = int.Parse(Console.ReadLine());

            if (guess > magic){

                Console.WriteLine("Too high!");

            }

            if (guess < magic){

                Console.WriteLine("Too low!");

            }

            count += 1;

            }
            while (guess != magic);


            Console.WriteLine($"That's it! The magic number was {magic}!");

            if (count == 1){

                Console.WriteLine("Hole in one!!!");

            } else{

            Console.WriteLine($"It took you {count} tries!");

            }

            Console.WriteLine("Play again? (yes/no)");
            playAgain = Console.ReadLine() == "yes";

        } while (playAgain);

        }
}