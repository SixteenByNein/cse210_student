class BreathingActivity : Activity
{

    TextEffects fx = new();

    public override string GetMenu()
    {

    return "Breathing activity";

    }

    public override bool Run()
    {



        fx.Plaque("This activity will help you relax by waling you through a breathing exrcise.");


        int breathTime = 4000;

        fx.Marquee("How many seconds would you like to do this activity for?");

        int duration = int.Parse(Console.ReadLine()) * 1000;

        fx.Spinner("Get ready...");

        int quantity = duration / (breathTime * 4);

    
        for(int i = 0; i < quantity; i++)
        {

            fx.Loadbar("Breathe in...", breathTime);
            fx.Loadbar("Hold...", breathTime);
            fx.Loadbar("Breath out...", breathTime);
            fx.Loadbar("Wait...", breathTime);

        }

        return true;

    }

}