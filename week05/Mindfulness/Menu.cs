//This menu class is largely overengineered for the demands of the assignment and pretty messy.
// I wasn't satisfied with how I did the menu in the previous assignment.
// This system is hypothetically infinitelty expandable.


//CREATIVITY:
//Last minute addition: The menu is now navigated with arrow keys and the enter key rather than a text input.


using System.Security.Cryptography;
using Microsoft.VisualBasic;

class Menu()
{

    TextEffects fx = new();

    //In the place of strings, I used the custom Activity class in this list. That way, I can call, using the index of the list, the Run() method.
    //This feels much nicer than using an "if else if" chain and is expandable if I wanted that.
    //The only weird part about it was that I had to create a method in each child of the activity class that returns the name of the
    //activity as it appears in the ui.
    List<Activity> _options;

    int cursor = 0;


    public void LoadMenu(List<Activity> options)
    {

        _options = options;

    }

    //This method takes the argument "first" to know if it should do the fancy animation or just print to the screen.
    //We don't want the animation if it's being refreshed to show the cursor in the new position.
    public void ShowMenu(bool first)
    {

        Console.Clear();

        fx.Marquee("MENU: use up and down arrow keys to navigate and ENTER to select");

        Console.WriteLine();

        List<string> displayed = [];

        int index = 0;

        foreach(Activity item in _options)
        {

            string text = item.GetMenu();

            if(cursor == index)
            {

                displayed.Add($"    {index + 1}. [{text}]");

            } else
            {

                displayed.Add($"    {index + 1}.  {text} ");

            }

            index = index + 1;

        }

        if(first)
        {

        fx.Scroll(displayed);

        } else
        {

        fx.Refresh(displayed);

        }

        //This next bit took much longer than it should have... The documentation was confusing but I figured it out.
        //In the place of the standard text input menu, I tried my hand at one controlled using arrow keys an the enter button.
        //I think it feels really good!
        
        ConsoleKeyInfo input = Console.ReadKey();



        if(input.Key.ToString() == "UpArrow")
        {

            cursor = (cursor - 1);

            if(cursor == -1)
            {cursor = _options.Count() - 1;}

            ShowMenu(false);

        }

        if(input.Key.ToString() == "DownArrow")
        {

            cursor = (cursor + 1) % _options.Count();
            ShowMenu(false);


        }

        if(input.Key.ToString() == "Enter")
        {

        Console.Clear();
        if(_options[cursor].Run())
        {
        ShowMenu(true);
        }

        }


    }


    

}