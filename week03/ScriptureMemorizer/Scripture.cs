using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Simple split by spaces. Each token becomes a Word (punctuation stays attached).
        string[] tokens = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string token in tokens)
        {
            _words.Add(new Word(token));
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string wordsText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{referenceText} {wordsText}";
    }

    public void HideRandomWords(int countToHide, Random rng)
    {
        // Stretch behavior: pick only from words not already hidden.
        List<int> visibleIndexes = new List<int>();

        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleIndexes.Add(i);
            }
        }

        if (visibleIndexes.Count == 0)
        {
            return;
        }

        // Hide up to countToHide, but not more than what is available.
        int hides = Math.Min(countToHide, visibleIndexes.Count);

        for (int i = 0; i < hides; i++)
        {
            int pick = rng.Next(visibleIndexes.Count);
            int wordIndex = visibleIndexes[pick];

            _words[wordIndex].Hide();

            // Remove so we do not hide the same word twice in a single round.
            visibleIndexes.RemoveAt(pick);
        }
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

    public double GetHiddenPercent()
    {
        if (_words.Count == 0)
        {
            return 100.0;
        }

        int hiddenCount = 0;

        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                hiddenCount++;
            }
        }

        return (hiddenCount / (double)_words.Count) * 100.0;
    }
}
