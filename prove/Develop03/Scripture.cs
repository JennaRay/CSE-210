using System;

class Scripture
{
    private List<Verse> _verses = new List<Verse>{};
    private string _reference;
    public bool _isHidden = false;
    
    public Scripture(string reference, string text, int num, int start)
    {
        if (num > 1)
        {  
            string[] verses = text.Split(";");
    
            foreach (string verse in verses)
            {   start += 1;

                Verse newVerse = new Verse(start, verse);
                _verses.Add(newVerse);
            }
        }
        else if (num == 1)
        {
            _verses.Add(new Verse(start, text));
        }
        _reference = reference;
    }

    public void Hide()
    {
        foreach (Verse verse in _verses)
        {
            verse.Hide();
        }

    }

    public void Display()
    {   Console.WriteLine($"{_reference}:");
        foreach (Verse verse in _verses)
        {
            verse.Display();
        }
    }

    public void CheckHidden()
    {
        foreach(Verse verse in _verses)
        {
            verse.CheckHidden();
            if (!verse._isHidden)
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