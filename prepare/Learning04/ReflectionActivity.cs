using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you overcame a challenge.",
        "Reflect on a moment when you helped someone in need.",
        "Consider a situation where you learned something new about yourself.",
        "Recall a time when you achieved a personal goal.",
        "Think about an experience that made you feel grateful."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself from this experience?",
        "How can you apply what you learned to future situations?",
        "What emotions did you feel during this experience?",
        "How has this experience shaped who you are today?"
    };

    private Random _random = new Random();

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on meaningful experiences in your life. Take a moment to think deeply and gain insights from your past.")
    {
        
    }


    public void PerformActivity()
    {
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        PauseWithAnimation(3);

        int elapsed = 0;
        while (elapsed < Duration)
        {
            string question = _questions[_random.Next(_questions.Count)];
            Console.WriteLine(question);
            PauseWithAnimation(4);
            elapsed += 4;
        }
    }
}