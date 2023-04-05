using System;
using System.Globalization;
using System.Runtime;
using System.Data;
class Calander
{
    private List<Week> _weeks = new List<Week>{};
    private List<Timer> _timers = new List<Timer>{};
    private int _month;
    private int _year;

    public Calander()
    {
        DateTime date = DateTime.Today;
        _year = date.Year;
        _month = date.Month;
        int days = System.DateTime.DaysInMonth(_year, _month);
        SetWeeks(days);
    }
    public List<Week> GetWeeks()
    {   
        return _weeks;
    }
    public List<Timer> GetTimers()
    {
        return _timers;
    }
    public int GetMonth()
    {
        return _month;
    }
    public int GetYear()
    {
        return _year;
    }

    public void SetWeeks(string weeks)
    {
        
    }

    public void SetTimers(string timers)
    {

    }
    public void SetMonth(string month)
    {
        _month = int.Parse(month);
    }
    public void SetYear(string year)
    {
        _year = int.Parse(year);
    }
    public void DisplayThisWeek()
    {
        Week week = FindThisWeek();
        DataTable table = week.CreateTable();
        foreach(DataRow dataRow in table.Rows)
        {
            foreach(var item in dataRow.ItemArray)
            {
                Console.WriteLine(item);
            }
        }
        Console.WriteLine("Select an option: 1) Change Plan, 2) View Today's Plan, 3) View Shopping List, 4)Back to Main Menu");
        int option = int.Parse(Console.ReadLine());
        
        switch (option)
        {
            case 1:
                Console.WriteLine("feature not ready");
                break;
            case 2:
                Console.WriteLine("feature not ready");
                break;
            case 3:
                Console.WriteLine("feature not ready");
                break;
            case 4:
                Console.WriteLine("feature not ready");
                break;
        }
    }

    private Week FindThisWeek()
    {
        foreach (Week week in _weeks)
        {
            if (week.CheckDays())
                return week;
        }
        return null;
    }
    public void DisplayCalander()
    {
        Console.WriteLine(_month.ToString());
        Console.WriteLine();
        DataTable table = CreateTable();
        Console.WriteLine(table.Rows.Count);
        foreach(DataRow dataRow in table.Rows)
        {
            foreach(var item in dataRow.ItemArray)
            {
                Console.WriteLine(item);
            }
        }
    }
    private DataTable CreateTable()
    {
        DataTable table = new DataTable();
        int weeks = 0;
        foreach (Week week in _weeks)
        {   
            weeks += 1;
            DataRow row = table.NewRow();
            row[0] = "Week " + weeks;
            DataRow row2 = table.NewRow();
            row2[0] = week.CreateTable();
        }
        return table;
    }

    private void SetWeeks(int days)
    {
        for (int i = 0; i >= days / 7; i += 7)
        {
            int first = 1;
            int last;
            for (int x = 1; x >= days; x += 1)
            {
                if (x % 7 == 0 || x == days)
                {
                    last = x;
                    Week week = new Week(first, last, _year, _month);
                    _weeks.Add(week);
                    first = last + 1;
                }
            }
        }

    }
}

class Week
{
    private List<Day> _days = new List<Day>{};

    public Week(int start, int end, int year, int month)
    {
        SetDays(start, end, year, month);
    }

    private void SetDays(int start, int end, int year, int month)
    {
        for (int i = start; i == end; i+=1)
        {
            DateTime date = new DateTime(year, month, i);
            _days.Add(new Day(i, date.ToString("dddd")));
        }
    }

    public List<Day> GetDays()
    {
        return _days;
    }

    public bool CheckDays()
    {
        int today = DateTime.Today.Day;
        foreach (Day day in _days)
        {
            if (day.GetNumber() == today)
            {
                return true;
            }
        }
        return false;
    }
    public DataTable CreateTable()
    {   
        DataTable table = new DataTable();
        DataRow row = table.NewRow();
        int count = 0;
        foreach (Day day in _days)
        {   
            row[count] = day.CreateTable();
            count += 1;
        }
        return table;
    }
}

class Day
{
    private int _number;
    private string _name;
    private Dictionary<string, Meal> _meals = new Dictionary<string, Meal>{
                                                {"Breakfast", new Breakfast()},
                                                {"Lunch", new Lunch()},
                                                {"Dinner", new Dinner()}
                                                                          };

    public Day(int num, string name)
    {
        _number = num;
        _name = name;
    }
    
    public string GetName()
    {
        return _name;
    }

    public Dictionary<string, Meal> GetMeals()
    {
        return _meals;
    }


    public DataTable CreateTable()
    {
        DataTable table = new DataTable();
        table.Columns.Add($"{_number} | {_name.ToUpper()}");
        foreach (var meal in _meals)
        {
            table.Rows.Add($"{meal.Key}: {meal.Value.DisplayName()}");
        }
        return table;        
    }

    public int GetNumber()
    {
        return _number;
    }
}