public class EternalGoal:Goal
{

    public override string GetTitle(int index)
{

    return $"{index}. {IsComplete()} {_shortName}";

}

    public override void MarkComplete(bool marked)
    {
        
    }


    public override int GetNumerator()
    {
        return 0;
    }

    public override int GetDenominator()
    {
        return 0;
    }

    public override int GoalType()
    {
        return 1;
    }

}