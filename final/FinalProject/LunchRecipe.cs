using System;
using System.Collections.Generic;


public class LunchRecipe : Recipe
{
    public LunchRecipe(string name, List<string> ingredients, List<string> instructions, List<string> categories) : base(name, ingredients, instructions, categories)
    {
        
    }
    public override void DisplayRecipe()
    {
        Console.WriteLine("\n--- Lunch Recipe ---");
        base.DisplayRecipe();
    }
}