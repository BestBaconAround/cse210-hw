using System;
using System.Text;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string GetDisplayText()
    {
        if (!_isHidden)
        {
            return _text;
        }

        // Hide letters with underscores, keep punctuation as-is.
        // This guarantees the number of underscores matches the number of letters.
        StringBuilder builder = new StringBuilder();

        foreach (char c in _text)
        {
            if (char.IsLetter(c))
            {
                builder.Append('_');
            }
            else
            {
                builder.Append(c);
            }
        }

        return builder.ToString();
    }
}
