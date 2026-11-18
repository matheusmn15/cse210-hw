using System;

// Represents a single word of the scripture, which can be shown or hidden.
public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (!_isHidden)
        {
            return _text;
        }

        // Replace only letters with underscores so punctuation (commas, periods) stays visible.
        string hidden = "";
        foreach (char c in _text)
        {
            hidden += char.IsLetter(c) ? '_' : c;
        }
        return hidden;
    }
}
