using System;

class User
{
    string _name;
    int _weight;
    enum Sex
    {
        F,
        M
    }
    Sex _bioSex;
    bool _isPregnant;
    List<Deficiency> _deficiencies = new List<Deficiency>();   
    List<Restriction> _restrictions = new List<Restriction>();

    public User()
    {

    }

    private void AddDeficiency()
    {

    }
    
    private void AddRestriction()
    {

    }

    private void SetPregnant()
    {

    }

    private void setSex()
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
