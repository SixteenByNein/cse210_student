public class EternalGoal:Goal
{

    public override string GetTitle(int index)
{

    return $"{index}. {IsComplete()} {_shortName}";

}

    public override void MarkComplete(bool marked)
    {
        
    }

}