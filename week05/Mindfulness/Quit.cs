//This is another weird part quirk of how I chose to write my program in my crucade against if statements and
//my desire to make the menu expandable. I made the quit option its own child class of activity.

class Quit : Activity
{

    public override string GetMenu()
    {

        return "Quit";

    }

    TextEffects fx = new();
    
    public override bool Run()
    {

        fx.Plaque("Have a great day!");

        return false;

    }
    

}