using System;
using System.Collections.Generic;

public class EternalQuestProgram
{
    static void Main()
    {
        List<Goal> goals = new List<Goal>();
        int totalScore = 0;
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Eternal Quest ---");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Exit");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter goal type (simple, eternal, checklist): ");
                    string type = Console.ReadLine().ToLower();

                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Description: ");
                    string desc = Console.ReadLine();

                    Console.Write("Points: ");
                    int points = int.Parse(Console.ReadLine());

                    if (type == "simple")
                        goals.Add(new SimpleGoal(name, desc, points));
                    else if (type == "eternal")
                        goals.Add(new EternalGoal(name, desc, points));
                    else if (type == "checklist")
                    {
                        Console.Write("Target completions: ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("Bonus points: ");
                        int bonus = int.Parse(Console.ReadLine());
                        goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                    }
                    break;

                case "2":
                    for (int i = 0; i < goals.Count; i++)
                        Console.WriteLine($"{i + 1}. {goals[i].Name} {goals[i].DisplayStatus()}");
                    Console.Write("Select goal to record: ");
                    int idx = int.Parse(Console.ReadLine()) - 1;
                    if (idx >= 0 && idx < goals.Count)
                    {
                        int earned = goals[idx].RecordEvent();
                        totalScore += earned;
                        Console.WriteLine($"You earned {earned} points!");
                    }
                    break;

                case "3":
                    Console.WriteLine("\n--- Goals ---");
                    foreach (var g in goals)
                        Console.WriteLine($"{g.Name}: {g.Description} Status: {g.DisplayStatus()}");
                    break;

                case "4":
                    Console.WriteLine($"Total Score: {totalScore}");
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}