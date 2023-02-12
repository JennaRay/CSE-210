using System;

class Scripture
{
    private List<Verse> _verses;
    private string _reference;
    public bool _isHidden;
    
    public Scripture(string reference, string text, int num, int start)
    {
        if (num > 1)
        {  
            string[] verses = text.Split(";");
    
            for (int i = 0; i <= num; i += 1, start++)
            {   

                Verse verse = new Verse(start, verses[i]);
                _verses.Append(verse);
            }
        }
        else if (num == 1)
        {
            Verse verse = new Verse(start, text);
            _verses.Append(verse);
        }
        _reference = reference;
    }

    public void Hide()
    {
        foreach (Verse verse in _verses)
        {
            verse.Hide();
        }

        foreach (Verse verse in _verses)
        {
            if (!verse._isHidden)
            {
                _isHidden = false;
            }
            
        }
    }

    public void Display()
    {   Console.WriteLine($"{_reference}:");
        foreach (Verse verse in _verses)
        {
            verse.Display();
        }
    }

}