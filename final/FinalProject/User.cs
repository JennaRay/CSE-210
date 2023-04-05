using System;

class User
{
    private string _name;
    private int _weight;
    public enum Sex
    {
        F,
        M
    }
    public Sex _bioSex;
    private bool _isPregnant;
    private List<Deficiency> _deficiencies = new List<Deficiency>();   
    private List<Restriction> _restrictions = new List<Restriction>();

    public User()
    {
        SetName();
        SetWeight();
        SetSex();
    }

    public string GetName()
    {
        return _name;
    }

    public int GetWeight()
    {
        return _weight;
    }

    public Sex GetSex()
    {
        return _bioSex;
    }

    public bool GetPregnant()
    {
        return _isPregnant;
    }

    private void AddDeficiency()
    {

    }
    
    private void AddRestriction()
    {

    }

    public void SetPregnant(string x)
    {
        _isPregnant = bool.Parse(x);
    }

    public void SetSex(string x)
    {
        if (x == "F")
        {
            _bioSex = Sex.F;
        }
        else {_bioSex = Sex.M;}
    }

    private void SetSex()
    {
        Console.WriteLine("For the purpose of knowing what your body needs, what is your biological sex? (F or M)");
        string answer = Console.ReadLine();
        bool setting = true;
        while (setting)
        {
            if (answer == "F")
            {
                _bioSex = Sex.F;
                setting = false;
            }
            else if (answer == "M")
            {
                _bioSex = Sex.M;
                setting = false;
            }
            else
            {
                Console.WriteLine("Please enter the biological sex that most closely applies to you (F or M): ");
                answer = Console.ReadLine();
            }
        }
    }

    public void SetWeight()
    {
        Console.WriteLine("Enter your weight in lbs: ");
        _weight = int.Parse(Console.ReadLine());
    }
    public void SetWeight(string weight)
    {
        _weight = int.Parse(weight);
    }
    public void SetName()
    {
        Console.WriteLine("Enter your name: ");
        _name = Console.ReadLine();
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public void DisplayProfile()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Weight: {_weight}");
        Console.WriteLine($"Biological Sex: {_bioSex}");


    }

    private void ProfileOptions()
    {
        Console.WriteLine();
        Console.WriteLine("Change Profile? (yes/no)");
        string answer = Console.ReadLine();

        if (answer.ToUpper() == "YES")
        {
            Console.WriteLine("Would you like to change: 1) Name, 2) Weight, 3) Biological Sex, 4) Deficiencies, 5) Dietary Restrictions");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    SetName();
                    break;
                case 2:
                    SetWeight();
                    break;
                case 3:
                    SetSex()
                    break;
                case 4: 
                    Console.WriteLine("This feature is not ready");
                    break;
                case 5:
                    Console.WriteLine("This feature is not ready");
                    break;
            }
        }
    }
}

class Restriction
{
    string _type;
    List<Ingredient> _excludes = new List<Ingredient>();

}

class Deficiency
{
    string _type;
    List<Nutrient> _needs = new List<Nutrient>();
}
