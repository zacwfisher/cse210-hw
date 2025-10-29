using System;
using System.Runtime.CompilerServices;
using System.IO;
using System.Linq;

// new class for storing the recipes
class RecipeStorage
{
    private readonly string _filePath = "recipeStorage.csv";

    public List<Recipe> LoadRecipes()
    {
        List<Recipe> recipe = new List<Recipe>();

        if (!File.Exists(_filePath))
        {
            return recipe;
        }

        var lines = File.ReadAllLines(_filePath).Skip(1); // found that this skips the header line in the csv file
        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            var parts = line.Split('|');
            if (parts.Length == 4)
            {
                string name = parts[0];
                List<string> ingredients = parts[1].Split(';').ToList();
                List<string> instructions = parts[2].Split(';').ToList();
                List<string> categories = parts[3].Split(';').ToList();

                recipe.Add(new Recipe(name, ingredients, instructions, categories));
            }
        }

        return recipe;
    }
    public void SaveRecipes(List<Recipe> recipes)
    {
        using (StreamWriter writer = new StreamWriter(_filePath))
        {
            writer.WriteLine("Name|Ingredients|Steps|Categories");

            foreach (var recipe in recipes)
            {
                string ingredients = string.Join(",", recipe.Ingredients);
                string steps = string.Join(",", recipe.Instructions);
                string categories = string.Join(",", recipe.Categories);

                writer.WriteLine($"{recipe.Name}|{ingredients}|{steps}|{categories}");
            }
        }
    }
}

