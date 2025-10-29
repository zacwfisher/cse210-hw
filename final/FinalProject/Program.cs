using System;

class Program
{
    static void Main(string[] args)
    {
        RecipeBook recipeBook = new RecipeBook();

        bool running = true;
        while (running)
        {
            Console.WriteLine("\n=== Recipe Manager ===");
            Console.WriteLine("1. Add Recipe");
            Console.WriteLine("2. View Recipes");
            Console.WriteLine("3. Get Suggestions");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    recipeBook.AddRecipe();
                    break;
                case "2":
                    recipeBook.DisplayAllRecipes();
                    break;
                case "3":
                    recipeBook.GetSuggestions();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}