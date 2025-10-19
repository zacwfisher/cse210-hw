using System;

class MindfulnessProgram
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an activity: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.StartActivity();
                    breathing.PerformActivity();
                    breathing.EndActivity();
                    break;

                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.StartActivity();
                    reflection.PerformActivity();
                    reflection.EndActivity();
                    break;

                case "3":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.\n");
                    break;
            }

            Console.WriteLine("goodbeye!");
        }
    }
}