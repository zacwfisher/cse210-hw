using System;

public class LunchRecipe : Recipe
{
    public LunchRecipe(string name, string ingredients, string instructions) : base(name, ingredients, instructions) { }

    public override void DisplayRecipe()
    {
        Console.WriteLine("\n--- Lunch Recipe ---");
        base.DisplayRecipe();
    }
}