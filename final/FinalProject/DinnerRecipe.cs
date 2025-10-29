using System;
using System.Collections.Generic;


public class DinnerRecipe : Recipe
{
    public DinnerRecipe(string name, List<string> ingredients, List<string> instructions, List<string> categories) : base(name, ingredients, instructions, categories)
    {
        
    }
    public override void DisplayRecipe()
    {
        Console.WriteLine("\n--- Dinner Recipe ---");
        base.DisplayRecipe();
    }
}