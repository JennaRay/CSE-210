using System;

public class Checklist : Goal
{
    int _numChecks;
    int _numCompleted;
    public Checklist(int points, string title, string description): base(points, title, description)
    {
        SetChecks();
    }
    public Checklist(int points, string title, string description, int checks, int numCompleted): base(points, title, description)
    {
        _numChecks = checks;
        _numCompleted = numCompleted;
    }

    private void SetChecks()
    {
        Console.WriteLine("How many times do you need to complete this goal? ");
        _numChecks = int.Parse(Console.ReadLine());
    }

    public override void SetCompleted()
    {
        _numCompleted += 1;
        if (_numCompleted == _numChecks)
        {
            _completed = true;
        }
    }

    public override string MakeString()
    {
        string saveString = _title + ":" + _description + ":" + _points + ":" + _completed + ";" + "checklist" + "," + _numCompleted;
        return saveString;
    }
}
