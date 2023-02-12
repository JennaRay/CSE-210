using System;

class Program
{   private static List<Scripture> _scriptures = new List<Scripture>{};
    private static Scripture _scripture;
    static void Main(string[] args)
    {
        StartUp();

        bool playing = true;
        while (playing)
        {
            string input = Console.ReadLine();
            if (input == "quit" || _scripture._isHidden)
            {
                playing = false;
            }
            else
            {
                Console.Clear();
                _scripture.Hide();
                _scripture.Display();
            }
        }

    }

    private static void CreateScriptures()
    {
        string[] lines = File.ReadAllLines("scriptures.txt");
        foreach (string line in lines)
        {   if (!string.IsNullOrWhiteSpace(line))
                {
                    string[] parts = line.Split("- ");

                    string reference = parts[0];
                    string text = parts[1];

                    string[] moreParts = reference.Split(":");
                    int numVerses = 1;
                    int start = moreParts[1][0];
                    if (moreParts[1].Contains("-"))
                    {
                        string[] verses = moreParts[1].Split("-");
                        start = int.Parse(verses[0]);
                        int end = int.Parse(verses[1]);
                        numVerses = end + 1 - start;
                    }
                    
                    Scripture scripture = new Scripture(reference, text, numVerses, start);
                    _scriptures.Append(scripture);
                }
        }       
    }

    private static Scripture PickScripture()
    {
        Random rnd = new Random();
        int num = rnd.Next(_scriptures.Count());
        Scripture scripture = _scriptures[num];
        return scripture;
    }

    private static void StartUp()
    {
        CreateScriptures();
        _scripture = PickScripture();
        _scripture.Display();
        Console.WriteLine("Hit enter to hide words, or type 'quit' to end program");

    }

}