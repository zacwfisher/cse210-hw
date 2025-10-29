using System;
using System.Collections.Generic;


public class DessertRecipe : Recipe
{
    public DessertRecipe(string name, List<string> ingredients, List<string> instructions, List<string> categories) : base(name, ingredients, instructions, categories)
    {
        
    }
    public override void DisplayRecipe()
    {
        Console.WriteLine("\n--- Dessert Recipe ---");
        base.DisplayRecipe();
    }
}