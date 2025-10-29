using System;
using System.Collections.Generic;

public class Recipe
{
    protected string _name;
    protected List<string> _ingredients;
    protected List<string> _instructions;
    protected List<string> _categories;

    public string Name { get { return _name; } }
    public List<string> Ingredients { get { return _ingredients; } }
    public List<string> Instructions { get { return _instructions; } }
    public List<string> Categories { get { return _categories; } }

    public Recipe(string name, List<string> ingredients, List<string> instructions, List<string> categories)
    {
        _name = name;
        _ingredients = ingredients ?? new List<string>();
        _instructions = instructions ?? new List<string>();
        _categories = categories ?? new List<string>();
    }

    public virtual void DisplayRecipe()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Ingredients:");
        Console.WriteLine(string.Join("\n", _ingredients));
        Console.WriteLine("Instructions:");
        for (int i = 0; i < _instructions.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_instructions[i]}");
        }
    }

    public void AddIngredients()
    {
        Console.WriteLine("Enter ingredients (type 'done' when finished): ");
        while (true)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input) || input.ToLower() == "done") break;
            Ingredients.Add(input);
        }
    }
}