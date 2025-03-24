public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        if (bottom == 0)
        {

        }
        _top = top;
        _bottom = bottom;
    }



    //Get and Set methods for the numerator

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    //Get and Set methods for the denominator

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}