using System;

public abstract class Recipe
{
    protected string _name;
    protected string _ingredients;
    protected string _instructions;

    public Recipe(string name, string ingredients, string instructions)
    {
        _name = name;
        _ingredients = ingredients;
        _instructions = instructions;
    }

    public virtual void DisplayRecipe()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Ingredients: {_ingredients}");
        Console.WriteLine($"Instructions: {_instructions}");
    }
}