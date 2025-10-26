using System;

public class DessertRecipe : Recipe
{
    public DessertRecipe(string name, string ingredients, string instructions) : base(name, ingredients, instructions) { }

    public override void DisplayRecipe()
    {
        Console.WriteLine("\n--- Dessert Recipe ---");
        base.DisplayRecipe();
    }
}