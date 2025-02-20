public abstract class Activity()
{

    public abstract void Initialize(float time, float distance);



    public abstract string GetName();


    public abstract float GetDistance();

    public abstract float GetSpeed();

    public abstract float GetPace();

    public string GetSummary()
    {

        return $"{DateTime.Now.ToString("dd/mm/yyyy")} {GetName()}: {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km.";

    }


}