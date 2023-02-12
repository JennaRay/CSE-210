using System;

class Verse
{
    private int _number;
    private List<Word> _words = new List<Word>{};
    public bool _isHidden = false;

    public Verse(int verseNumber, string text)
    {
        _number = verseNumber;
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }

    }

    public void Hide()
    {
        foreach (Word word in _words)
        {   
            Random rnd = new Random();
            int hide = rnd.Next(2);
            if (hide == 1)
            {
                word._isHidden = true;
            }
        }
        
    }

    public void Display()
    {
        Console.WriteLine("    ");
        foreach (Word word in _words)
        {
            word.Display();
        }
    }

    public void CheckHidden()
    {
        foreach (Word word in _words)
        {
            if (!word._isHidden)
            {
                _isHidden = false;
        
            }
        }

        if (_isHidden != false)
        {
            _isHidden = true;
        }

    }

}