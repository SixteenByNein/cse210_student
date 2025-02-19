public abstract class Activity()
{


    //I made the Run() method return a boolean because, as I've written it, I wouldn't be able to get the quit option to actually quit.
    //In the ShowMenu() method of the Menu class, uses an if statement to determine if it returns to the menu after the activity is finished.
    public abstract bool Run();


    public abstract string GetMenu();



}