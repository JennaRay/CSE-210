using System;
using System.IO;

class Program
{
    public static string _fileName;
    public static Journal _journal;
    public static void Main(string[] args)
    {   
        _journal = new Journal();
        bool playing = true;
        while (playing)
        {
            int action = Menu.PromptMenu();
            
            if (action != 5 )
            {
                if (action == 1)
                {   
                     if (_fileName == null)
                     {
                        getFileName();
                     } 

                     _journal.NewEntry(); 
                }
                else if (action == 2)
                {   
                    if (_fileName == null)
                     {
                        getFileName();
                     } 
                    _journal.Display();
                }
                else if (action == 3) 
                {
                    Console.WriteLine("Enter file name: ");
                    _journal._fileName = Console.ReadLine();
                    _journal.Load();
                }
                else if (action == 4)
                {   
                    Console.WriteLine("What file would you like to save to? ");
                    string saveFileName = Console.ReadLine();
                    _journal._fileName = saveFileName;
                    _journal.Save();
                }
            }
            else
            {
                Console.WriteLine("Ok bye");
                playing = false;
            }
        }
    }

    private static void getFileName()
    {
        Console.WriteLine("Please load a Journal first");
        Console.WriteLine("Enter file name: ");
        _fileName = Console.ReadLine();
        _journal =  new Journal(_fileName);
        _journal._fileName = _fileName;
        _journal.Load();
    }
}