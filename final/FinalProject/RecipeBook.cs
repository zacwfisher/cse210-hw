using System;
using System.Collections.Generic;

public class RecipeBook
{
    private List<Recipe> _recipes = new List<Recipe>();
    private RecipeStorage _storage = new RecipeStorage();

    public RecipeBook()
    {
        _recipes = _storage.LoadRecipes();
    }

    public void AddRecipe()
    {
        Console.Write("Enter recipe name: ");
        String name = Console.ReadLine();

        Console.Write("Enter ingredients (press Enter after each ingredient, type 'done' when finished): ");
        List<string> ingredients = new List<string>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done") break;
            ingredients.Add(input);
        }

        Console.WriteLine("Enter instructions (press Enter after each step, type 'done' when finished):");
        List<string> steps = new List<string>();
        int stepCount = 1;
        while (true)
        {
            Console.Write($"Step {stepCount}: ");
            string step = Console.ReadLine();
            if (step.ToLower() == "done") break;
            steps.Add(step);
            stepCount++;
        }

        Console.WriteLine("Enter categories (e.g., Lunch, Dinner, Dessert). Press Enter after each, type 'done' when finished: ");
        List<string> categories = new List<string>();
        while (true)
        {
            string cat = Console.ReadLine();
            if (cat.ToLower() == "done") break;
            categories.Add(cat);
        }


        Recipe recipe = new Recipe(name, ingredients, steps, categories);
        _recipes.Add(recipe);

        _storage.SaveRecipes(_recipes); // hopefully updates csv file
        Console.WriteLine($"\n✅ '{name}' added successfully and saved!\n");
    }

    public void DisplayAllRecipes()
    {
        HashSet<string> displayed = new HashSet<string>();

        Console.WriteLine("\n📚 All Recipes:");
        foreach (var recipe in _recipes)
        {
            if (!displayed.Contains(recipe.Name))
            {
                recipe.DisplayRecipe();
                displayed.Add(recipe.Name);
            }
        }
    }

    public void GetRecipeByName()
    {
        Console.Write("Enter recipe name to search: ");
        string name = Console.ReadLine().Trim();

        foreach (var recipe in _recipes)
        {
            if (recipe.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                recipe.DisplayRecipe();
                return;
            }
        }
        
        Console.WriteLine("❌ Recipe not found.");
    }
    
    public void GetSuggestions()
    {
        Console.WriteLine("Suggestions feature coming soon!");
    }
}