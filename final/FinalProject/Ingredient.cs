
using System;
class Ingredient
{
    private string _name;
    public enum foodGroup
    {
        Vegetable,
        Fruit,
        Grain,
        Dairy,
        Meat,
        Legume,
        NutsandSeeds
    }
    private foodGroup _foodGroup;
    private int _calories;
    private List<Nutrient> _nutrients = new List<Nutrient>{};

    public Ingredient(string name, foodGroup type, int calories)
    {
        _name = name;
        _foodGroup = type;
        _calories = calories;
        CreateNutrients(name);
    }

    public Ingredient(string name, foodGroup type)
    {
        _name = name;
        _foodGroup = type;
        _calories = CalculateCalories();
        CreateNutrients(name);
    }

    private int CalculateCalories()
    {

    }

    private void CreateNutrients(string name)
    {
        // Access food database API
        // AC: hDbhVs8P34XfGhOcifxfkqgiSlUp9GU5FccZjIrz
    }
}

class Nutrient
{
    string _name;
    int _dailyValue;

    public Nutrient(string name, int value)
    {
        _name = name;
        _dailyValue = value;
    }
}