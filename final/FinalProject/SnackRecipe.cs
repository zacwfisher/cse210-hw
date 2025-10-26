using System;

public class SnackRecipe : Recipe
{
    public SnackRecipe(string name, string ingredients, string instructions) : base(name, ingredients, instructions) { }

    public override void DisplayRecipe()
    {
        Console.WriteLine("\n--- Snack Recipe ---");
        base.DisplayRecipe();
    }
}