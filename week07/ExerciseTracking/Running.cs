class Running:Activity
{


    float _time;
    float _distance;


    public override string GetName()
    {
        return("Running");
    }

    public override void Initialize(float time, float distance)
    {

        _time = time;
        _distance = distance;

    }




    public override float GetDistance()
    {

        return _distance;

    }

    public override float GetSpeed()
    {

        return (GetDistance() / _time) * 60;

    }

    public override float GetPace()
    {

        return _time / GetDistance();

    }

}