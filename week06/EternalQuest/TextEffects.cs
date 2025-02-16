//Creativity: This class provides for a few asthetic text animations.


public class TextEffects()
{

    public void Marquee(string text, int speed = 20, int wait = 500)
    {

        foreach(char letter in text)
        {


            Console.Write(letter);

            Thread.Sleep(speed);

        }

        Thread.Sleep(wait);

    }

    public void LinePrint(List<string> lines, int speed = 40, int wait = 700)
    {

        Console.Clear();

        foreach(string item in lines)
        {

            Console.WriteLine(item);

            Thread.Sleep(speed);

        }

    }


}