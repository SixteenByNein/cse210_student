class Swimming:Activity
{


    float _time;
    float _laps;


    public override string GetName()
    {
        return("Swimming");
    }

    public override void Initialize(float time, float laps)
    {

        _time = time;
        _laps = laps;

    }




    public override float GetDistance()
    {

        return _laps * 50 / 1000;

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