using System;

class Timer
{   
    string _name;
    bool _isActive = false;
    string _notifMessage;

    public Timer(string name, string message)
    {
        _name = name;
        _notifMessage = message;
        _isActive = true;
    }

    protected void StartTimer()
    {

    }
    protected bool CheckIfDone()
    {

    }

    protected void Deactivate()
    {
        _isActive = false;
    }

    protected void Notify()
    {

    }
}

class ExpirationTimer : Timer
{
    DateTime _startDate;
    DateTime _endDate;
    Meal _meal;

    public ExpirationTimer(Meal meal, string name, string message) : base(name, message)
    {
        _meal = meal;
        GetStartDate();
        GetEndDate();
    } 

    protected void GetStartDate()
    {
        _startDate = DateTime.Now;
    }

    protected void GetEndDate()
    {
        _endDate = _startDate.AddDays(_meal.GetExpiration());
    }
}

class RecipeTimer : Timer
{
    DateTime _startTime;
    DateTime _endTime;
    int _minutes;

    public RecipeTimer(int minutes, string name, string message) : base(name, message)
    {
        _startTime = DateTime.Now;
        _minutes = minutes;
        SetEndTime();
    }

    protected void SetEndTime()
    {
        _endTime = _startTime.AddMinutes(_minutes);
    }
    protected void CalculateSeconds()
    {
    
    }

    protected void Animation()
    {

    }

    protected void CountDown()
    {

    }
}