public class Fraction
{

    int _top;
    int _bottom;

    public Fraction()
    {

        _top = 1;
        _bottom = 1;

    }

    public Fraction(int numerator)
    {

        _top = numerator;
        _bottom = 1;

    }

    public Fraction(int numerator, int denominator)
    {

        _top = numerator;
        _bottom = denominator;

    }

}