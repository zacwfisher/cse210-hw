using System;

public class DinnerRecipe : Recipe
{
    public DinnerRecipe(string name, string ingredients, string instructions) : base(name, ingredients, instructions) { }

    public override void DisplayRecipe()
    {
        Console.WriteLine("\n--- Dinner Recipe ---");
        base.DisplayRecipe();
    }
}