using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
    };

    private Random _random = new Random();

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    public void PerformActivity()
    {
    string prompt = _prompts[_random.Next(_prompts.Count)];
    Console.WriteLine(prompt);
    Console.WriteLine("You have a few seconds to start thinking...");
    PauseWithAnimation(3);

    DateTime start = DateTime.Now;
    int count = 0;

    while ((DateTime.Now - start).TotalSeconds < Duration)
    {
        Console.Write("Enter item: ");
        Console.ReadLine();
        count++;
    }

    Console.WriteLine($"You listed {count} items!");
    }
}