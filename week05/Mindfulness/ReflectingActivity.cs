class ReflectingActivity : Activity
{

    TextEffects fx = new();

    public override string GetMenu()
    
    {

    return "Reflection activity";

    }

    public override bool Run()
    {

        int breathingRoom = 500;


        Random rand = new();

        fx.Plaque("This activity will help you reflect on times in your life when you've seen God's hand.");
        
        Console.WriteLine("");

        fx.Marquee("How long would you like this activity to last?");

        int duration = int.Parse(Console.ReadLine()) * 1000;

        fx.Marquee(prompts[rand.Next(prompts.Count())]);

        Console.WriteLine();

        fx.Marquee("Press enter when you're ready to continue.");

        Console.ReadLine();

        for(int i = 0; i < duration / breathingRoom; i++)
        {

        fx.Spinner(followUps[rand.Next(followUps.Count())]);

        Thread.Sleep(breathingRoom);

        }

        Console.ReadLine();

        return true;



    }





    List<string> prompts =
    [
"Think of a time you felt God's love.",
"Think of a time you were given an unexpected compliment.",
"Think of a time you did something new.",
"Think of a time you came to appreciate your family."
    ];

    List<string> followUps =
    [
"What did you learn from this?",
"Why was this important to you?",
"How has this experience allowed you to bless others?",
"Who do you know that needs the same blessing?",
    ];

}