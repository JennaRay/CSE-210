using System;

class Calander
{
    List<Week> _weeks = new List<Week>{};
    List<Timer> _timers = new List<Timer>{};
    DateTime _date;
}

class Week
{
    List<Day> _days = new List<Day>{};

}

class Day
{
    int _number;
    List<Meal> _meals = new List<Meal>{};
}