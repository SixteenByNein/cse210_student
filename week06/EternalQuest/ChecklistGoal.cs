
public class ChecklistGoal:Goal
{
    
    int _numerator = 0;
    int _denominator = 1;


    public void SetNumerator(int numerator)
    {

        _numerator = numerator;

    }

    public void SetDenominator(int denominator)
    {

        _denominator = denominator;

    }

    public override string GetTitle(int index)
    {

    return $"{index}. {IsComplete()} {_shortName} {_numerator}/{_denominator}";

    }

    public static implicit operator ChecklistGoal(SimpleGoal v)
    {
        throw new NotImplementedException();
    }

    public override void MarkComplete(bool marked)
    {

        if(_numerator < _denominator)
        {
            _numerator = _numerator + 1;
        }

        if(_numerator == _denominator)
        {

            _complete = marked;


        }
    }

}