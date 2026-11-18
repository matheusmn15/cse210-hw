using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // No parameters: initializes the fraction to 1/1.
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // One parameter: the top number; the bottom is set to 1.
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Two parameters: the top and bottom numbers.
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

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
        return (double)_top / (double)_bottom;
    }
}
