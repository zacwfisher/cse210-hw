using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing exercises. Clear your mind and focus on your breathing.")
    {

    }
    
    public void PerformActivity()
    {
        int elapsed = 0;
        while (elapsed < Duration)
        {
            Console.WriteLine("Breathe in...");
            PauseWithAnimation(4);
            elapsed += 4;

            if (elapsed >= Duration) break;

            Console.WriteLine("Breathe out...");
            PauseWithAnimation(6);
            elapsed += 6;
        }
    }
}