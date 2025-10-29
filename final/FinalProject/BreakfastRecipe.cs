using System;
using System.Collections.Generic;

public class BreakfastRecipe : Recipe
{
    public BreakfastRecipe(string name, List<string> ingredients, List<string> instructions, List<string> categories) : base(name, ingredients, instructions, categories)
    {
        
    }
    public override void DisplayRecipe()
    {
        Console.WriteLine("\n--- Breakfast Recipe ---");
        base.DisplayRecipe();
    }
}