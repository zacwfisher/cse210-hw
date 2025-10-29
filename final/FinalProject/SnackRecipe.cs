using System;

public class SnackRecipe : Recipe
{
    public SnackRecipe(string name, List<string> ingredients, List<string> instructions, List<string> categories)
    : base(name, ingredients, instructions, categories)
    {
        
    }
    public override void DisplayRecipe()
    {
        Console.WriteLine("\n--- Snack Recipe ---");
        base.DisplayRecipe();
    }
}