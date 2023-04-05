using System;

class Meal
{
    private List<String> _recipeSteps = new List<string>();
    private int _servings;
    private string _name;
    private List<Ingredient> _ingredients = new List<Ingredient>();
    private bool _isCompleted = false;
    private int _expirationDays;

    public Meal(int recipe, int servings)
    {
        _recipeSteps = CreateStepsList(recipe);
        _ingredients = CreateIngredientsList(recipe);
        _name = SetName(recipe);
        _servings = servings;
        _expirationDays = CalculateExpiration();
    }

    public string DisplayName()
    {
        return _name;
    }

    public int GetExpiration()
    {
        return _expirationDays;
    }

    private string SetName(int recipe)
    {

    }

    private List<String> CreateStepsList(int recipe)
    {

    }
    
    private List<Ingredient> CreateIngredientsList(int recipe)
    {

    }

    private int CalculateExpiration()
    {
        
    }
}

class Breakfast : Meal
{

}

class Lunch : Meal
{

}

class Dinner : Meal
{

}