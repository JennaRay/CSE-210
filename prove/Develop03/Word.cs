using System;
class Word
{
    private string _text;
    public bool _isHidden;
    
    public Word(string text)
    {
        _text = text;
    }

    public void Display()
    {
        char[] punct = {'.', ',', ':', ';', '"', '-', '!', '?', '(', ')'};
        if (_isHidden)
        {
            foreach (char x in _text)
            {
                if (!punct.Contains(x))
                {
                    Console.Write('_');
                }
            }
        }
        else {Console.Write(_text + " ");}
    }
}