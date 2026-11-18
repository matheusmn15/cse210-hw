using System;
using System.Collections.Generic;

// Holds a reference and the list of words of a scripture, and hides words over time.
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private static Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (string part in text.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            _words.Add(new Word(part));
        }
    }

    // Hides the given number of random words, choosing only words that are still visible.
    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        List<string> parts = new List<string>();
        foreach (Word word in _words)
        {
            parts.Add(word.GetDisplayText());
        }
        return $"{_reference.GetDisplayText()} {string.Join(" ", parts)}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
