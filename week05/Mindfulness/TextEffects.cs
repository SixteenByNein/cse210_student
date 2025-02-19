using System.Security.Cryptography.X509Certificates;

//I may have gone overboard with this one...
//Here is another part of the assignment that shows creativity.
//I made a text effects class for the last assignment I did but I was able to do a lot more on this one.

class TextEffects()
{

    //This one displays a list of strings one at a time as though they were unrolled from a scroll.
    public void Scroll(List<string> texts, int speed = 100)
    {

        foreach(string item in texts)
        {

            Console.WriteLine(item);
            Thread.Sleep(speed);

        }

    }

    //This one is just like the scroll one but it isn't animated. I had to add this one to refresh the console everytime I moved the cursor in the menu.

    public void Refresh(List<string> texts)
    {

        foreach(string item in texts)
        {

            Console.WriteLine(item);

        }

    }

    //This one shows one line, introducing a letter at a time. It adds life to the user interface.
    public void Marquee(string text, int speed = 20)
    {

        foreach(char letter in text)
        {

            Console.Write(letter);

        }

    }

    //This one fills a loading bar of a desired width for a desired amount of time.

    public void Loadbar(string text, int duration, int width = 20)
    {

        int slice = duration/width;
        
        for(int i = 0; i < width; i++)
        {

            string progressBar = "";

            for(int j = 0; j < width; j++)
            {

                if(j <= i)
                {

                    progressBar = $"{progressBar}■";

                }
                else
                {

                progressBar = $"{progressBar} ";

                }

            }

            Console.Clear();

            Console.WriteLine(text);
            Console.Write($"[{progressBar}]");
            Console.WriteLine();

            Thread.Sleep(slice);

        }        

    }

    //Here's the one animation that _was_ called for in the assignment... I used a special character because I though it looked cool.

    public void Spinner(string text, int speed = 200, int duration = 4000)
    {

        for(int i = 0; i < duration / (speed * 4); i++)
        {
        Console.WriteLine($"{text}◐");
        Thread.Sleep(speed);
        Console.Clear();

        Console.WriteLine($"{text}◓");
        Thread.Sleep(speed);
        Console.Clear();

        Console.WriteLine($"{text}◑");
        Thread.Sleep(speed);
        Console.Clear();

        Console.WriteLine($"{text}◒");
        Thread.Sleep(speed);
        Console.Clear();
        }

    }


    //This one creates a padded border around a line of text.

    public void Plaque(string text, int padding = 3)
    {

        Console.Clear();
        Console.Write("┌");
        for(int i = 0; i < (text.Count() + 2 * padding) - 2; i++)
        {
            Console.Write("─");
        }
        Console.WriteLine("┐");

        for(int i = 0; i < padding - 1; i++)
        {

            Console.Write("│");
            for(int j = 0; j < (text.Count() + 2 * padding) - 2; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("│");

        }

        Console.Write("│");

        for(int i = 0; i < padding - 1; i++)
        {

            Console.Write(" ");

        }

        Console.Write(text);

        for(int i = 0; i < padding - 1; i++)
        {

            Console.Write(" ");

        }

        Console.WriteLine("│");

        for(int i = 0; i < padding - 1; i++)
        {

            Console.Write("│");
            for(int j = 0; j < (text.Count() + 2 * padding) - 2; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("│");

        }

        Console.Write("└");
        for(int i = 0; i < (text.Count() + 2 * padding) - 2; i++)
        {
            Console.Write("─");
        }
        Console.WriteLine("┘");

    }


}