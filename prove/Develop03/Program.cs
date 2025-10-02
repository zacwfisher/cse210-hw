using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static Random _appRandom = new Random();

    static void Main(string[] args)
    {
        // Create scriptures
        Reference reference1 = new Reference("John", 3, 16);
        Scripture scripture1 = new Scripture(reference1,
            "For God so loved the world, that he gave his only begotten Son...");

        Reference reference2 = new Reference("Proverbs", 3, 5);
        Scripture scripture2 = new Scripture(reference2,
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding.");

        Reference reference3 = new Reference("Philippians", 4, 13);
        Scripture scripture3 = new Scripture(reference3,
            "I can do all things through Christ which strengtheneth me.");

        List<Scripture> scriptures = new List<Scripture> { scripture1, scripture2, scripture3 };

        Scripture currentScripture = scriptures[_appRandom.Next(scriptures.Count)];

        string userInput = "";

        while (userInput.ToLower() != "quit" && !currentScripture.IsCompletelyHidden())
        {
            Console.Clear();
            currentScripture.DisplayScripture();
            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");

            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {
                currentScripture.HideWords();
            }
        }

        Console.Clear();
        currentScripture.DisplayScripture();

        if (currentScripture.IsCompletelyHidden())
            Console.WriteLine("\nAll words are hidden. Good job!");
        else
            Console.WriteLine("\nProgram ended. You can try again to memorize more!");

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}

