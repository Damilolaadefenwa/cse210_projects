using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text, bool isHidden)
    {
        _text = text;
        _isHidden = false;
    }

    //This method hide words
    public void Hide()
    {
        _isHidden = true;
    }
    //This method makes words visibile
    public void Show()
    {
        _isHidden = false;
    }

    // This method
    public bool isHidden()
    {
        return _isHidden;
    }

    //This method
    public string GetDisplayText()
    {
        if (isHidden())
        {
            return new string('_', _text.Length);
        }
        return _text;
    }


}