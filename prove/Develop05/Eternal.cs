using System;

public class Eternal : Goal
{
    private int _timesCompleted;

    public Eternal(int points, string title, string description): base(points, title, description)
    {
        _timesCompleted = 0;
    }

    public Eternal(int points, string title, string description, int completed): base(points, title, description)
    {
        _timesCompleted = completed;
    }
    public override string MakeString()
    {
        string saveString = _title + ":" + _description + ":" + _points + ":" + _completed + ";" + "eternal" + "," + _timesCompleted;
        return saveString;
    }
}