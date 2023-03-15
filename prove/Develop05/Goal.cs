using System;

public class Goal
{
    protected int _points;
    protected string _title;
    protected string _description;

    protected bool _completed;

    public Goal(int points, string title, string description)
    {
        _points = points;
        _title = title;
        _description = description;
        _completed = false;
    }

    public bool GetCompleted()
    {
        return _completed;
    }
    
    public virtual void SetCompleted()
    {
        _completed = true;
    }

    public virtual string MakeString()
    {
        string saveString = _title + ":" + _description + ":" + _points + ":" + _completed + ";" + "simple";
        return saveString;
    }
    
    public bool CheckTitle(string title)
    {
        if (_title == title)
        {
            return true;
        }
        return false;
    }
    
    protected int GetPoints()
    {
        
    }
    public void DisplayPoints()
    {
        Console.Write(_points);
    }
    

    public void DisplayGoal()
    {
        char check;
        if (GetCompleted())
        {
            check = 'X';
        }
        else {check = ' ';}
        Console.WriteLine($"[{check}]{_title}: {_description}");
    }


}