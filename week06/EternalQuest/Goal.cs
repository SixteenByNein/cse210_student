public abstract class Goal()
{

public string _shortName = "";
string _description = "";
public int _points = 0;

public bool _complete = false;


public string GetName()
{

    return _shortName;

}

public abstract string GetTitle(int index);

public string GetDescription()
{

    return _description;

}


public void SetName(string name)
{

    _shortName = name;

}

public void SetDescription(string description)
{

    _description = description;

}

public void SetPoints(int points)
{

    _points = points;

}

public abstract void MarkComplete(bool marked);

public int addPoints()
{

    return _points;

}

public string IsComplete()
{

    if(_complete)
    {
        return "[X]";
    }else
    {
        return "[ ]";
    }

}

public bool IsCompleteBool()
{

    return _complete;

}



}