using System;
using System.Collections.Generic;

public class RecipeBook
{
    private List<Recipe> _recipes = new List<Recipe>();

    public void AddRecipe()
    {
        Console.Write("Enter recipe name: ");
        String name = Console.ReadLine();

        Console.Write("Enter ingredients: ");
        string ingredients = Console.ReadLine();

        Console.Write("Enter instructions: ");
        string instructions = Console.ReadLine();

        Console.WriteLine("Choose recipe type: ");
        Console.WriteLine("1. Breakfast\n2. Lunch\n3. Dinner\n4. Dessert\n5. Snack");
        Console.Write("Choice: ");
        string typeChoice = Console.ReadLine();

        Recipe recipe = typeChoice switch
        {
            "1" => new BreakfastRecipe(name, ingredients, instructions),
            "2" => new LunchRecipe(name, ingredients, instructions),
            "3" => new DinnerRecipe(name, ingredients, instructions),
            "4" => new DessertRecipe(name, ingredients, instructions),
            "5" => new SnackRecipe(name, ingredients, instructions),
            _ => null
        };

        if (recipe != null)
        {
            _recipes.Add(recipe);
            Console.WriteLine("Recipe added successfully!");
        }
        else
        {
            Console.WriteLine("Invalid recipe type selected.");
        }
    }

    public void DisplayAllRecipes()
    {
        if (_recipes.Count == 0)
        {
            Console.WriteLine("No recipes available.");
            return;
        }

        foreach (var recipe in _recipes)
        {
            recipe.DisplayRecipe();
        }
    }

    public void GetSuggestions()
    {
        Console.WriteLine("Suggestions feature coming soon!");
    }
}