using System;

public class BreakfastRecipe : Recipe
{
    public BreakfastRecipe(string name, string ingredients, string instructions) : base(name, ingredients, instructions) { }

    public override void DisplayRecipe()
    {
        Console.WriteLine("\n--- Breakfast Recipe ---");
        base.DisplayRecipe();
    }
}